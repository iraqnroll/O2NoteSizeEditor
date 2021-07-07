namespace O2NoteSizeEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoundWhite = new System.Windows.Forms.TextBox();
            this.RoundBlue = new System.Windows.Forms.TextBox();
            this.RoundYellow = new System.Windows.Forms.TextBox();
            this.SquareWhite = new System.Windows.Forms.TextBox();
            this.SquareBlue = new System.Windows.Forms.TextBox();
            this.SquareYellow = new System.Windows.Forms.TextBox();
            this.RoundNoteBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SquareNoteBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.RoundNoteBox.SuspendLayout();
            this.SquareNoteBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStrip
            // 
            this.FileToolStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.FileToolStrip.Name = "FileToolStrip";
            this.FileToolStrip.Size = new System.Drawing.Size(37, 20);
            this.FileToolStrip.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.openToolStripMenuItem.Text = "Import";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // RoundWhite
            // 
            this.RoundWhite.Location = new System.Drawing.Point(6, 19);
            this.RoundWhite.Name = "RoundWhite";
            this.RoundWhite.Size = new System.Drawing.Size(72, 20);
            this.RoundWhite.TabIndex = 1;
            this.RoundWhite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Check);
            // 
            // RoundBlue
            // 
            this.RoundBlue.Location = new System.Drawing.Point(7, 45);
            this.RoundBlue.Name = "RoundBlue";
            this.RoundBlue.Size = new System.Drawing.Size(71, 20);
            this.RoundBlue.TabIndex = 2;
            this.RoundBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Check);
            // 
            // RoundYellow
            // 
            this.RoundYellow.Location = new System.Drawing.Point(7, 71);
            this.RoundYellow.Name = "RoundYellow";
            this.RoundYellow.Size = new System.Drawing.Size(71, 20);
            this.RoundYellow.TabIndex = 3;
            this.RoundYellow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Check);
            // 
            // SquareWhite
            // 
            this.SquareWhite.Location = new System.Drawing.Point(6, 19);
            this.SquareWhite.Name = "SquareWhite";
            this.SquareWhite.Size = new System.Drawing.Size(71, 20);
            this.SquareWhite.TabIndex = 4;
            this.SquareWhite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Check);
            // 
            // SquareBlue
            // 
            this.SquareBlue.Location = new System.Drawing.Point(5, 45);
            this.SquareBlue.Name = "SquareBlue";
            this.SquareBlue.Size = new System.Drawing.Size(72, 20);
            this.SquareBlue.TabIndex = 5;
            this.SquareBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Check);
            // 
            // SquareYellow
            // 
            this.SquareYellow.Location = new System.Drawing.Point(6, 71);
            this.SquareYellow.Name = "SquareYellow";
            this.SquareYellow.Size = new System.Drawing.Size(71, 20);
            this.SquareYellow.TabIndex = 6;
            this.SquareYellow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Check);
            // 
            // RoundNoteBox
            // 
            this.RoundNoteBox.Controls.Add(this.label3);
            this.RoundNoteBox.Controls.Add(this.label2);
            this.RoundNoteBox.Controls.Add(this.label1);
            this.RoundNoteBox.Controls.Add(this.RoundWhite);
            this.RoundNoteBox.Controls.Add(this.RoundBlue);
            this.RoundNoteBox.Controls.Add(this.RoundYellow);
            this.RoundNoteBox.Location = new System.Drawing.Point(12, 37);
            this.RoundNoteBox.Name = "RoundNoteBox";
            this.RoundNoteBox.Size = new System.Drawing.Size(165, 112);
            this.RoundNoteBox.TabIndex = 7;
            this.RoundNoteBox.TabStop = false;
            this.RoundNoteBox.Text = "Round Notes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yellow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Blue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "White";
            // 
            // SquareNoteBox
            // 
            this.SquareNoteBox.Controls.Add(this.label6);
            this.SquareNoteBox.Controls.Add(this.label5);
            this.SquareNoteBox.Controls.Add(this.label4);
            this.SquareNoteBox.Controls.Add(this.SquareWhite);
            this.SquareNoteBox.Controls.Add(this.SquareBlue);
            this.SquareNoteBox.Controls.Add(this.SquareYellow);
            this.SquareNoteBox.Location = new System.Drawing.Point(243, 37);
            this.SquareNoteBox.Name = "SquareNoteBox";
            this.SquareNoteBox.Size = new System.Drawing.Size(176, 112);
            this.SquareNoteBox.TabIndex = 8;
            this.SquareNoteBox.TabStop = false;
            this.SquareNoteBox.Text = "Square Notes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Yellow";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Blue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "White";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(163, 155);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 54);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save values";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 221);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(434, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 243);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.SquareNoteBox);
            this.Controls.Add(this.RoundNoteBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "O2NoteResizer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.RoundNoteBox.ResumeLayout(false);
            this.RoundNoteBox.PerformLayout();
            this.SquareNoteBox.ResumeLayout(false);
            this.SquareNoteBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox RoundWhite;
        private System.Windows.Forms.TextBox RoundBlue;
        private System.Windows.Forms.TextBox RoundYellow;
        private System.Windows.Forms.TextBox SquareWhite;
        private System.Windows.Forms.TextBox SquareBlue;
        private System.Windows.Forms.TextBox SquareYellow;
        private System.Windows.Forms.GroupBox RoundNoteBox;
        private System.Windows.Forms.GroupBox SquareNoteBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}

