namespace Assignment_2__My_Juke_Box_
{
    partial class SetupForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbox_tracks = new System.Windows.Forms.ListBox();
            this.lbox_trackList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_ClearTracks = new System.Windows.Forms.Button();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.btn_Move = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancelsetup = new System.Windows.Forms.Button();
            this.btn_setupOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.btn_Next);
            this.groupBox1.Controls.Add(this.btn_Previous);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_Move);
            this.groupBox1.Controls.Add(this.btn_Copy);
            this.groupBox1.Controls.Add(this.btn_ClearTracks);
            this.groupBox1.Controls.Add(this.btn_import);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbox_trackList);
            this.groupBox1.Controls.Add(this.lbox_tracks);
            this.groupBox1.Location = new System.Drawing.Point(26, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbox_tracks
            // 
            this.lbox_tracks.FormattingEnabled = true;
            this.lbox_tracks.Location = new System.Drawing.Point(6, 32);
            this.lbox_tracks.Name = "lbox_tracks";
            this.lbox_tracks.Size = new System.Drawing.Size(181, 225);
            this.lbox_tracks.TabIndex = 0;
            // 
            // lbox_trackList
            // 
            this.lbox_trackList.FormattingEnabled = true;
            this.lbox_trackList.Location = new System.Drawing.Point(371, 84);
            this.lbox_trackList.Name = "lbox_trackList";
            this.lbox_trackList.Size = new System.Drawing.Size(204, 173);
            this.lbox_trackList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Present Genera Track List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Genera Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "General";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Imported Tracks";
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(11, 275);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(175, 23);
            this.btn_import.TabIndex = 6;
            this.btn_import.Text = "Import Tracks from Directory";
            this.btn_import.UseVisualStyleBackColor = true;
            // 
            // btn_ClearTracks
            // 
            this.btn_ClearTracks.Location = new System.Drawing.Point(10, 312);
            this.btn_ClearTracks.Name = "btn_ClearTracks";
            this.btn_ClearTracks.Size = new System.Drawing.Size(175, 21);
            this.btn_ClearTracks.TabIndex = 7;
            this.btn_ClearTracks.Text = "Clear Import Tracks";
            this.btn_ClearTracks.UseVisualStyleBackColor = true;
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(211, 89);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(134, 23);
            this.btn_Copy.TabIndex = 8;
            this.btn_Copy.Text = "Copy Track >>";
            this.btn_Copy.UseVisualStyleBackColor = true;
            // 
            // btn_Move
            // 
            this.btn_Move.Location = new System.Drawing.Point(211, 132);
            this.btn_Move.Name = "btn_Move";
            this.btn_Move.Size = new System.Drawing.Size(133, 23);
            this.btn_Move.TabIndex = 9;
            this.btn_Move.Text = "Move Track >>";
            this.btn_Move.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 56);
            this.button1.TabIndex = 10;
            this.button1.Text = "Delete Track from Genera";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(362, 281);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(71, 51);
            this.btn_Previous.TabIndex = 11;
            this.btn_Previous.Text = "<<Previous";
            this.btn_Previous.UseVisualStyleBackColor = true;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(500, 281);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 51);
            this.btn_Next.TabIndex = 12;
            this.btn_Next.Text = "Next >>";
            this.btn_Next.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(439, 281);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(55, 22);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(439, 310);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(55, 22);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_cancelsetup
            // 
            this.btn_cancelsetup.Location = new System.Drawing.Point(555, 416);
            this.btn_cancelsetup.Name = "btn_cancelsetup";
            this.btn_cancelsetup.Size = new System.Drawing.Size(81, 29);
            this.btn_cancelsetup.TabIndex = 1;
            this.btn_cancelsetup.Text = "Cancel";
            this.btn_cancelsetup.UseVisualStyleBackColor = true;
            this.btn_cancelsetup.Click += new System.EventHandler(this.btn_cancelsetup_Click);
            // 
            // btn_setupOk
            // 
            this.btn_setupOk.Location = new System.Drawing.Point(465, 416);
            this.btn_setupOk.Name = "btn_setupOk";
            this.btn_setupOk.Size = new System.Drawing.Size(81, 29);
            this.btn_setupOk.TabIndex = 2;
            this.btn_setupOk.Text = "OK";
            this.btn_setupOk.UseVisualStyleBackColor = true;
            this.btn_setupOk.Click += new System.EventHandler(this.btn_setupOk_Click);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.btn_setupOk);
            this.Controls.Add(this.btn_cancelsetup);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupForm";
            this.Text = "Setup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbox_trackList;
        private System.Windows.Forms.ListBox lbox_tracks;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Move;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_ClearTracks;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cancelsetup;
        private System.Windows.Forms.Button btn_setupOk;
    }
}