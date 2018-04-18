namespace Assignment_2__My_Juke_Box_
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
            this.label1 = new System.Windows.Forms.Label();
            this.Lst_PlayList = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lst_GenreList = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Hierachical = new System.Windows.Forms.MenuStrip();
            this.setUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hScroll_Genre = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.Hierachical.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(368, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright © 2018. Ben Kata";
            // 
            // Lst_PlayList
            // 
            this.Lst_PlayList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lst_PlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lst_PlayList.FormattingEnabled = true;
            this.Lst_PlayList.Location = new System.Drawing.Point(169, 347);
            this.Lst_PlayList.Name = "Lst_PlayList";
            this.Lst_PlayList.Size = new System.Drawing.Size(180, 173);
            this.Lst_PlayList.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.Lime;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(130, 293);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Lst_GenreList
            // 
            this.Lst_GenreList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lst_GenreList.FormattingEnabled = true;
            this.Lst_GenreList.HorizontalScrollbar = true;
            this.Lst_GenreList.Location = new System.Drawing.Point(170, 192);
            this.Lst_GenreList.MultiColumn = true;
            this.Lst_GenreList.Name = "Lst_GenreList";
            this.Lst_GenreList.Size = new System.Drawing.Size(179, 69);
            this.Lst_GenreList.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.OrangeRed;
            this.textBox2.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(169, 169);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(180, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "General";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(112, 71);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(300, 52);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            // 
            // Hierachical
            // 
            this.Hierachical.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Hierachical.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setUpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.Hierachical.Location = new System.Drawing.Point(0, 622);
            this.Hierachical.Name = "Hierachical";
            this.Hierachical.Size = new System.Drawing.Size(508, 24);
            this.Hierachical.TabIndex = 7;
            this.Hierachical.Text = "menuStrip1";
            // 
            // setUpToolStripMenuItem
            // 
            this.setUpToolStripMenuItem.Name = "setUpToolStripMenuItem";
            this.setUpToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.setUpToolStripMenuItem.Text = "Set up";
            this.setUpToolStripMenuItem.Click += new System.EventHandler(this.setUpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // hScroll_Genre
            // 
            this.hScroll_Genre.Location = new System.Drawing.Point(170, 245);
            this.hScroll_Genre.Name = "hScroll_Genre";
            this.hScroll_Genre.Size = new System.Drawing.Size(178, 16);
            this.hScroll_Genre.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(508, 646);
            this.Controls.Add(this.hScroll_Genre);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Lst_GenreList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lst_PlayList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hierachical);
            this.MainMenuStrip = this.Hierachical;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "My Juke Box v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.Hierachical.ResumeLayout(false);
            this.Hierachical.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Lst_PlayList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox Lst_GenreList;
        private System.Windows.Forms.TextBox textBox2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.MenuStrip Hierachical;
        private System.Windows.Forms.ToolStripMenuItem setUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.HScrollBar hScroll_Genre;
    }
}

