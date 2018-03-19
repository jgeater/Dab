using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Dab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backup_CheckedChanged(object sender, EventArgs e)
        {
            Type.Text = "Copy my data to:";
        }

        private void restore_CheckedChanged(object sender, EventArgs e)
        {
            Type.Text = "Copy my data from:";
        }


        //show the browse dialog when the browse button is clicked
        private void browse1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDLG = new FolderBrowserDialog();
            folderDLG.ShowNewFolderButton = true;
            DialogResult = folderDLG.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                data_loc.Text = folderDLG.SelectedPath;
                cpy_data.Enabled = true;
            }
        }

        private void data_loc_TextChanged(object sender, EventArgs e)
        {
            //check space and user rights and disable copy button if problems are found
            cpy_data.Enabled = true;
        }

        private void cpy_data_Click(object sender, EventArgs e)
        {
            //set up varibles pointing to the users name and  folders
            copy_Cur.Visible = true;
            string usr_Name = System.Environment.UserName;
            string mdoc_Path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dt_path = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fav_path = System.Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
            string Mus_path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string pic_path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            string vid_path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            string dl_path = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
            string ct_path = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{56784854-C6CB-462B-8169-88E350ACB882}", String.Empty).ToString();

            // if copy to is checked
            if (backup.Checked == true)
            {
                //create a foilder with the users name if it doesnt exist and append it to the data_log path
                string new_data_loc = Path.Combine(data_loc.Text + @"\" + usr_Name);
                Directory.CreateDirectory(new_data_loc);

                //If the directory is not empty ask to delete everything in it
                if (Directory.EnumerateFileSystemEntries(new_data_loc).Any())
                {
                    DialogResult dialogResult = MessageBox.Show("The selected directory already has userdata for "+usr_Name+" in it." + Environment.NewLine + "Do you want to Delete it?" + Environment.NewLine + Environment.NewLine + "Press Yes to DELETE ALL OF THE DATA in this folder!" + Environment.NewLine + "Press No to Exit.", "User data found", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            System.IO.Directory.Delete(new_data_loc, true);
                        }

                        catch (Exception)
                        {
                            MessageBox.Show("Failed to Delete some data." + Environment.NewLine + "Manually delete the remaining data and rerun the application" + Environment.NewLine + "Press OK to Exit");
                            Environment.ExitCode=1;
                            Environment.Exit(1);
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Environment.Exit(0);
                    }
                }
               


                //copy desktop if checked
                if (usr_Desktop.Checked == true)
                {
                    string sourcePath = dt_path;
                    string targetPath = new_data_loc + @"\Desktop";
                    copy_Cur.Text= "Now Copying:"+targetPath;
                    toolStripStatusLabel1.Text = "Now Copying:" + targetPath;
                    DirectoryCopy(sourcePath, targetPath , true);
                }

                //copy Documents if checked
                if (usr_Documents.Checked == true)
                {
                    string sourcePath = mdoc_Path;
                    string targetPath = new_data_loc + @"\Documents";
                    copy_Cur.Text = "Now Copying:" + targetPath;
                    toolStripStatusLabel1.Text = "Now Copying:" + targetPath;
                    DirectoryCopy(sourcePath, targetPath, true);
                }

                //copy Favorites if checked
                if (usr_Favorites.Checked == true)
                {
                    string sourcePath = fav_path;
                    string targetPath = new_data_loc + @"\Favorites";
                    copy_Cur.Text = "Now Copying:" + targetPath;
                    toolStripStatusLabel1.Text = "Now Copying:" + targetPath;
                    DirectoryCopy(sourcePath, targetPath, true);
                }

                //copy Pictures if checked
                if (usr_Pictures.Checked == true)
                {
                    string sourcePath = pic_path;
                    string targetPath = new_data_loc + @"\Pictures";
                    copy_Cur.Text = "Now Copying:" + targetPath;
                    toolStripStatusLabel1.Text = "Now Copying:" + targetPath;
                    DirectoryCopy(sourcePath, targetPath, true);
                }

                //copy Music if checked
                if (usr_Music.Checked == true)
                {
                    string sourcePath = Mus_path;
                    string targetPath = new_data_loc + @"\Music";
                    copy_Cur.Text = "Now Copying:" + targetPath;
                    toolStripStatusLabel1.Text = "Now Copying:" + targetPath;
                    DirectoryCopy(sourcePath, targetPath, true);
                }

                //copy Video if checked
                if (usr_Videos.Checked == true)
                {
                    string sourcePath = vid_path;
                    string targetPath = new_data_loc + @"\Video";
                    copy_Cur.Text = "Now Copying:" + targetPath;
                    toolStripStatusLabel1.Text = "Now Copying:" + targetPath;
                    DirectoryCopy(sourcePath, targetPath, true);
                }

                //copy Downloads if checked
                if (usr_Downloads.Checked == true)
                {
                    string sourcePath = dl_path;
                    string targetPath = new_data_loc + @"\Downloads";
                    copy_Cur.Text = "Now Copying:" + targetPath;
                    toolStripStatusLabel1.Text = "Now Copying:" + targetPath;
                    DirectoryCopy(sourcePath, targetPath, true);
                }

                //copy contacts if checked
                if (usr_Contacts.Checked == true)
                {
                    string sourcePath = ct_path;
                    string targetPath = new_data_loc + @"\Contacts";
                    copy_Cur.Text = "Now Copying:" + targetPath;
                    toolStripStatusLabel1.Text = "Now Copying:" + targetPath;
                    DirectoryCopy(sourcePath, targetPath, true);
                }

            }



            //if copy from it checked
            if (restore.Checked == true)
            {
                string new_data_loc = Path.Combine(data_loc.Text + @"\" + usr_Name);

                if (!Directory.Exists(new_data_loc))
                {
                    MessageBox.Show("No User data found for " + usr_Name);
                    Environment.ExitCode = 1;
                    Environment.Exit(1);
                }

                DialogResult dialogResult = MessageBox.Show("Any duplicate files will be over written" + Environment.NewLine + "Do you want to Continue?" + Environment.NewLine + Environment.NewLine + "Press Yes to Continue " + Environment.NewLine + "Press No to Exit.", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    Environment.Exit(0);
                }

                //copy desktop if checked
                if (usr_Desktop.Checked == true)
                {
                    string targetPath = dt_path;
                    string sourcePath = new_data_loc + @"\Desktop";
                    copy_Cur.Text = "Now Copying:" + targetPath;
                    toolStripStatusLabel1.Text = "Now Copying:" + targetPath;
                    DirectoryCopy(sourcePath, targetPath, true);
                }

                //copy Documents if checked
                if (usr_Documents.Checked == true)
                {
                    string targetPath = mdoc_Path;
                    string sourcePath = new_data_loc + @"\Documents";
                    copy_Cur.Text = "Now Copying:" + targetPath;
                    toolStripStatusLabel1.Text = "Now Copying:" + targetPath;
                    DirectoryCopy(sourcePath, targetPath, true);
                }

                //copy Favorites if checked
                if (usr_Favorites.Checked == true)
                {
                    string targetPath = fav_path;
                    string sourcePath = new_data_loc + @"\Favorites";
                    copy_Cur.Text = "Now Copying:" + targetPath;
                    toolStripStatusLabel1.Text = "Now Copying:" + targetPath;
                    DirectoryCopy(sourcePath, targetPath, true);
                }

                //copy Pictures if checked
                if (usr_Pictures.Checked == true)
                {
                    string targetPath = pic_path;
                    string sourcePath = new_data_loc + @"\Pictures";
                    copy_Cur.Text = "Now Copying:" + targetPath;
                    toolStripStatusLabel1.Text = "Now Copying:" + targetPath;
                    DirectoryCopy(sourcePath, targetPath, true);
                }

                //copy Music if checked
                if (usr_Music.Checked == true)
                {
                    string targetPath = Mus_path;
                    string sourcePath = new_data_loc + @"\Music";
                    copy_Cur.Text = "Now Copying:" + targetPath;
                    toolStripStatusLabel1.Text = "Now Copying:" + targetPath;
                    DirectoryCopy(sourcePath, targetPath, true);
                }

                //copy Video if checked
                if (usr_Videos.Checked == true)
                {
                    string targetPath = vid_path;
                    string sourcePath = new_data_loc + @"\Video";
                    copy_Cur.Text = "Now Copying:" + targetPath;
                    toolStripStatusLabel1.Text = "Now Copying:" + targetPath;
                    DirectoryCopy(sourcePath, targetPath, true);
                }

                //copy Downloads if checked
                if (usr_Downloads.Checked == true)
                {
                    string targetPath = dl_path;
                    string sourcePath = new_data_loc + @"\Downloads";
                    copy_Cur.Text = "Now Copying:" + targetPath;
                    toolStripStatusLabel1.Text = "Now Copying:" + targetPath;
                    DirectoryCopy(sourcePath, targetPath, true);
                }

                //copy contacts if checked
                if (usr_Contacts.Checked == true)
                {
                    string targetPath = ct_path;
                    string sourcePath = new_data_loc + @"\Contacts";
                    copy_Cur.Text = "Now Copying:" + targetPath;
                    toolStripStatusLabel1.Text = "Now Copying:" + targetPath;
                    DirectoryCopy(sourcePath, targetPath, true);
                }



            }



            //All done
            copy_Cur.Text = "Copy Completed";
            toolStripStatusLabel1.Text = "Copy Completed";
            cur_act.Text = "";
            MessageBox.Show("Data copy complete!");
        }


        private void DirectoryCopy(
                string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();
            Application.DoEvents();

            // If the source directory does not exist, throw an exception.
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory does not exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }


            // Get the file contents of the directory to copy.
            FileInfo[] files = dir.GetFiles();
            progressBar1.Maximum = files.Count();
            progressBar1.Value = 0;


            foreach (FileInfo file in files)
            {
                // Create the path to the new copy of the file.
               
                string temppath = Path.Combine(destDirName, file.Name);

                // Copy the file.
                cur_act.Text = ("Now Copying " + temppath);
                progressBar1.Value++;
                file.CopyTo(temppath, true);
                
            }

            // If copySubDirs is true, copy the subdirectories.
            if (copySubDirs)
            {

                foreach (DirectoryInfo subdir in dirs)
                {
                    // Create the subdirectory.
                    string temppath = Path.Combine(destDirName, subdir.Name);

                    // Copy the subdirectories.
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                    
                }
            }

        }

        private void updateprogressbar()
        {
            progressBar1.Value++;

        }

        private void q_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
