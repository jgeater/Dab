namespace Dab
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
            this.backup = new System.Windows.Forms.RadioButton();
            this.restore = new System.Windows.Forms.RadioButton();
            this.usr_Documents = new System.Windows.Forms.CheckBox();
            this.usr_Desktop = new System.Windows.Forms.CheckBox();
            this.usr_Favorites = new System.Windows.Forms.CheckBox();
            this.usr_Pictures = new System.Windows.Forms.CheckBox();
            this.usr_Music = new System.Windows.Forms.CheckBox();
            this.usr_Videos = new System.Windows.Forms.CheckBox();
            this.usr_Downloads = new System.Windows.Forms.CheckBox();
            this.usr_Contacts = new System.Windows.Forms.CheckBox();
            this.Type = new System.Windows.Forms.Label();
            this.data_loc = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.browse1 = new System.Windows.Forms.Button();
            this.cpy_data = new System.Windows.Forms.Button();
            this.copy_Cur = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cur_act = new System.Windows.Forms.Label();
            this.q_button = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backup
            // 
            this.backup.AutoSize = true;
            this.backup.Checked = true;
            this.backup.Location = new System.Drawing.Point(95, 56);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(88, 24);
            this.backup.TabIndex = 0;
            this.backup.TabStop = true;
            this.backup.Text = "Backup";
            this.backup.UseVisualStyleBackColor = true;
            this.backup.CheckedChanged += new System.EventHandler(this.backup_CheckedChanged);
            // 
            // restore
            // 
            this.restore.AutoSize = true;
            this.restore.Location = new System.Drawing.Point(224, 56);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(91, 24);
            this.restore.TabIndex = 1;
            this.restore.Text = "Restore";
            this.restore.UseVisualStyleBackColor = true;
            this.restore.CheckedChanged += new System.EventHandler(this.restore_CheckedChanged);
            // 
            // usr_Documents
            // 
            this.usr_Documents.AutoSize = true;
            this.usr_Documents.Location = new System.Drawing.Point(95, 200);
            this.usr_Documents.Name = "usr_Documents";
            this.usr_Documents.Size = new System.Drawing.Size(117, 24);
            this.usr_Documents.TabIndex = 2;
            this.usr_Documents.Text = "Documents";
            this.usr_Documents.UseVisualStyleBackColor = true;
            // 
            // usr_Desktop
            // 
            this.usr_Desktop.AutoSize = true;
            this.usr_Desktop.Location = new System.Drawing.Point(95, 230);
            this.usr_Desktop.Name = "usr_Desktop";
            this.usr_Desktop.Size = new System.Drawing.Size(95, 24);
            this.usr_Desktop.TabIndex = 3;
            this.usr_Desktop.Text = "Desktop";
            this.usr_Desktop.UseVisualStyleBackColor = true;
            // 
            // usr_Favorites
            // 
            this.usr_Favorites.AutoSize = true;
            this.usr_Favorites.Location = new System.Drawing.Point(95, 260);
            this.usr_Favorites.Name = "usr_Favorites";
            this.usr_Favorites.Size = new System.Drawing.Size(100, 24);
            this.usr_Favorites.TabIndex = 4;
            this.usr_Favorites.Text = "Favorites";
            this.usr_Favorites.UseVisualStyleBackColor = true;
            // 
            // usr_Pictures
            // 
            this.usr_Pictures.AutoSize = true;
            this.usr_Pictures.Location = new System.Drawing.Point(95, 290);
            this.usr_Pictures.Name = "usr_Pictures";
            this.usr_Pictures.Size = new System.Drawing.Size(92, 24);
            this.usr_Pictures.TabIndex = 5;
            this.usr_Pictures.Text = "Pictures";
            this.usr_Pictures.UseVisualStyleBackColor = true;
            // 
            // usr_Music
            // 
            this.usr_Music.AutoSize = true;
            this.usr_Music.Location = new System.Drawing.Point(95, 320);
            this.usr_Music.Name = "usr_Music";
            this.usr_Music.Size = new System.Drawing.Size(76, 24);
            this.usr_Music.TabIndex = 6;
            this.usr_Music.Text = "Music";
            this.usr_Music.UseVisualStyleBackColor = true;
            // 
            // usr_Videos
            // 
            this.usr_Videos.AutoSize = true;
            this.usr_Videos.Location = new System.Drawing.Point(95, 350);
            this.usr_Videos.Name = "usr_Videos";
            this.usr_Videos.Size = new System.Drawing.Size(84, 24);
            this.usr_Videos.TabIndex = 7;
            this.usr_Videos.Text = "Videos";
            this.usr_Videos.UseVisualStyleBackColor = true;
            // 
            // usr_Downloads
            // 
            this.usr_Downloads.AutoSize = true;
            this.usr_Downloads.Location = new System.Drawing.Point(95, 380);
            this.usr_Downloads.Name = "usr_Downloads";
            this.usr_Downloads.Size = new System.Drawing.Size(114, 24);
            this.usr_Downloads.TabIndex = 8;
            this.usr_Downloads.Text = "Downloads";
            this.usr_Downloads.UseVisualStyleBackColor = true;
            // 
            // usr_Contacts
            // 
            this.usr_Contacts.AutoSize = true;
            this.usr_Contacts.Location = new System.Drawing.Point(95, 410);
            this.usr_Contacts.Name = "usr_Contacts";
            this.usr_Contacts.Size = new System.Drawing.Size(99, 24);
            this.usr_Contacts.TabIndex = 9;
            this.usr_Contacts.Text = "Contacts";
            this.usr_Contacts.UseVisualStyleBackColor = true;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(95, 105);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(127, 20);
            this.Type.TabIndex = 11;
            this.Type.Text = "Copy my data to:";
            // 
            // data_loc
            // 
            this.data_loc.Location = new System.Drawing.Point(99, 129);
            this.data_loc.Name = "data_loc";
            this.data_loc.Size = new System.Drawing.Size(431, 26);
            this.data_loc.TabIndex = 12;
            this.data_loc.TextChanged += new System.EventHandler(this.data_loc_TextChanged);
            // 
            // browse1
            // 
            this.browse1.Location = new System.Drawing.Point(536, 129);
            this.browse1.Name = "browse1";
            this.browse1.Size = new System.Drawing.Size(121, 26);
            this.browse1.TabIndex = 13;
            this.browse1.Text = "Browse";
            this.browse1.UseVisualStyleBackColor = true;
            this.browse1.Click += new System.EventHandler(this.browse1_Click);
            // 
            // cpy_data
            // 
            this.cpy_data.Enabled = false;
            this.cpy_data.Location = new System.Drawing.Point(95, 533);
            this.cpy_data.Name = "cpy_data";
            this.cpy_data.Size = new System.Drawing.Size(117, 41);
            this.cpy_data.TabIndex = 14;
            this.cpy_data.Text = "Copy Data";
            this.cpy_data.UseVisualStyleBackColor = true;
            this.cpy_data.Click += new System.EventHandler(this.cpy_data_Click);
            // 
            // copy_Cur
            // 
            this.copy_Cur.AutoSize = true;
            this.copy_Cur.Location = new System.Drawing.Point(95, 611);
            this.copy_Cur.Name = "copy_Cur";
            this.copy_Cur.Size = new System.Drawing.Size(0, 20);
            this.copy_Cur.TabIndex = 15;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 794);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(811, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(95, 602);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(558, 29);
            this.progressBar1.TabIndex = 17;
            // 
            // cur_act
            // 
            this.cur_act.AutoSize = true;
            this.cur_act.Location = new System.Drawing.Point(91, 668);
            this.cur_act.Name = "cur_act";
            this.cur_act.Size = new System.Drawing.Size(0, 20);
            this.cur_act.TabIndex = 18;
            // 
            // q_button
            // 
            this.q_button.Location = new System.Drawing.Point(536, 533);
            this.q_button.Name = "q_button";
            this.q_button.Size = new System.Drawing.Size(117, 41);
            this.q_button.TabIndex = 19;
            this.q_button.Text = "Quit";
            this.q_button.UseVisualStyleBackColor = true;
            this.q_button.Click += new System.EventHandler(this.q_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(811, 816);
            this.Controls.Add(this.q_button);
            this.Controls.Add(this.cur_act);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.copy_Cur);
            this.Controls.Add(this.cpy_data);
            this.Controls.Add(this.browse1);
            this.Controls.Add(this.data_loc);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.usr_Contacts);
            this.Controls.Add(this.usr_Downloads);
            this.Controls.Add(this.usr_Videos);
            this.Controls.Add(this.usr_Music);
            this.Controls.Add(this.usr_Pictures);
            this.Controls.Add(this.usr_Favorites);
            this.Controls.Add(this.usr_Desktop);
            this.Controls.Add(this.usr_Documents);
            this.Controls.Add(this.restore);
            this.Controls.Add(this.backup);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAB- Sumplie User Data Copy";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton backup;
        private System.Windows.Forms.RadioButton restore;
        private System.Windows.Forms.CheckBox usr_Documents;
        private System.Windows.Forms.CheckBox usr_Desktop;
        private System.Windows.Forms.CheckBox usr_Favorites;
        private System.Windows.Forms.CheckBox usr_Pictures;
        private System.Windows.Forms.CheckBox usr_Music;
        private System.Windows.Forms.CheckBox usr_Videos;
        private System.Windows.Forms.CheckBox usr_Downloads;
        private System.Windows.Forms.CheckBox usr_Contacts;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.TextBox data_loc;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button browse1;
        private System.Windows.Forms.Button cpy_data;
        private System.Windows.Forms.Label copy_Cur;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label cur_act;
        private System.Windows.Forms.Button q_button;
    }
}

