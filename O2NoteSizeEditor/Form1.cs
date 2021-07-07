using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace O2NoteSizeEditor
{
    public partial class Form1 : Form
    {

        const int HeightPosOffset = 0x18;             //Offset between each height byte in the note object (it's actually 0x19, but c# I/O is trash so i have to subtract 1 byte).
        const int InitRoundPos = 0x7D3E0;               
        const int InitSquarePos = 0x7D493;
        List<int> NoteHeights = new List<int>();      //List to store height data
        FileInfo binPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openO2Binary = new OpenFileDialog())
            {
                openO2Binary.InitialDirectory = "C:\\";
                openO2Binary.Filter = "exe files (*.exe)|*.exe";
                openO2Binary.FilterIndex = 1;
                openO2Binary.CheckFileExists = true;
                openO2Binary.CheckPathExists = true;

                if(openO2Binary.ShowDialog() == DialogResult.OK)
                {
                    binPath = new FileInfo(openO2Binary.FileName);

                    using (var BinStream = new FileStream(binPath.FullName, FileMode.Open, FileAccess.ReadWrite))
                    {
                        BinStream.Position = InitRoundPos;
                        string specifier = "X";


                        for (int notecount = 0; notecount < 6; notecount++)
                        {
                            if (notecount == 0)
                            {
                                NoteHeights.Add(BinStream.ReadByte());
                                BinStream.Position += HeightPosOffset;
                            }
                            if (notecount != 2 && notecount > 0)
                            {
                                NoteHeights.Add(BinStream.ReadByte());
                                BinStream.Position += HeightPosOffset + 0x4;
                            }
                            else if (notecount == 2)                          //Indicates that we read all of the round note section.
                            {
                                NoteHeights.Add(BinStream.ReadByte());
                                BinStream.Position = InitSquarePos;         //Move on to square note section

                            }
                        }

                        StatusLabel.Text = "Successfully read the height values from : " + InitRoundPos.ToString(specifier) + " + (" + HeightPosOffset.ToString(specifier) + ")";
                        BinStream.Close();
                    }

                    //Populate the text boxes with retrieved height values. 

                    RoundWhite.Text = NoteHeights[0].ToString();
                    RoundBlue.Text = NoteHeights[1].ToString();
                    RoundYellow.Text = NoteHeights[2].ToString();
                    SquareWhite.Text = NoteHeights[3].ToString();
                    SquareBlue.Text = NoteHeights[4].ToString();
                    SquareYellow.Text = NoteHeights[5].ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (binPath == null) 
            {
                MessageBox.Show("You must open OTwo.exe (or other client) first!", "Error");
                return;
            }

            NoteHeights.Clear();

            foreach(Control c in RoundNoteBox.Controls)
            {
                if(c.GetType() == typeof(TextBox)) // Get the new height values for round notes.
                {
                    if (c.Text == "") 
                     {
                        c.Text = "1";

                        NoteHeights.Add(1); // Set it to 1 in-case user set it empty
                    } 
                    else 
                    {
                        NoteHeights.Add(Convert.ToInt32(c.Text));
                    }
                }
            }

            foreach(Control c in SquareNoteBox.Controls)
            {
                if(c.GetType() == typeof(TextBox)) // Get new height values for the square notes.
                {
                    if (c.Text == "") 
                    {
                        c.Text = "1";

                        NoteHeights.Add(1); // Set it to 1 in-case user set it empty
                    } 
                    else 
                    {
                        NoteHeights.Add(Convert.ToInt32(c.Text));
                    }
                }
            }

            /*NOTE THAT WE ALSO HAVE TO RE-WRITE THE AMOUNT OF FRAMES THE NOTES WILL BE RENDERED TO 1, OTHERWISE 
             THE RENDERED NOTES WILL FLICKER BETWEEN THEIR ORIGINAL AND EDITED SIZES*/

            using (var BinStream = new FileStream(binPath.FullName, FileMode.Open, FileAccess.ReadWrite))
            {
                BinStream.Position = InitRoundPos;
                string specifier = "X";
                long tempPos;

                Console.WriteLine("\n");
                for (int notecount = 0; notecount < 6; notecount++)
                {
                    if (notecount == 0)
                    {
                        BinStream.WriteByte(Convert.ToByte(NoteHeights[notecount]));
                        tempPos = BinStream.Position;

                        BinStream.Position += 3; //the frame value is 4 bytes away.
                        BinStream.WriteByte(0x1);
                        BinStream.Position = tempPos; //return the position to the height address.
                        
                        BinStream.Position += HeightPosOffset;
                    }
                    if (notecount != 2 && notecount > 0)
                    {
                        BinStream.WriteByte(Convert.ToByte(NoteHeights[notecount]));                
                        tempPos = BinStream.Position;

                        BinStream.Position += 3; //the frame value is 4 bytes away.
                        BinStream.WriteByte(0x1); 
                        BinStream.Position = tempPos; //return the position to the height address.
                        

                        BinStream.Position += HeightPosOffset + 0x4;
                    }
                    else if (notecount == 2)                          //Indicates that we read all of the round note section.
                    {
                        BinStream.WriteByte(Convert.ToByte(NoteHeights[notecount]));
                        tempPos = BinStream.Position;

                        BinStream.Position += 3; //the frame value is 4 bytes away.
                        BinStream.WriteByte(0x1);
                        BinStream.Position = tempPos; //return the position to the height address.
                        
                        BinStream.Position = InitSquarePos;         //Move on to square note section
                    }
                }

                StatusLabel.Text = "Successfully wrote new height values from : " + InitRoundPos.ToString(specifier) + " + (" + HeightPosOffset.ToString(specifier) + ")";
                BinStream.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = "About";
            string message = "Note height changer by iraq n roll";
            MessageBoxButtons btn = MessageBoxButtons.OK;
            DialogResult aboutresult = MessageBox.Show(message, title, btn);
        }

        public void textbox_Check(object sender, KeyPressEventArgs e) 
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
