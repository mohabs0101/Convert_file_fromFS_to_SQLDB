using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convert_FS_to_DB
{
    public partial class Form1 : Form
    {
        public static string photo_con_ = ConfigurationManager.ConnectionStrings["photo_con"].ConnectionString;
        SqlConnection photo_con = new SqlConnection(photo_con_);

        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_OFD_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                   string  sourcePath = fbd.SelectedPath;
                    //array of directories
                    string[] dirs = Directory.GetDirectories(fbd.SelectedPath);

                    //access first dir 
                    foreach ( var item in dirs)
                    {//take its name 
                        var directoryName = new DirectoryInfo(item).Name;
                        //read its files
                        string[] files = Directory.GetFiles(item);

                        //loop on its files and insert them to db
                        foreach (var item2 in files)
                        {
                            string fileName = new FileInfo(item2).Name;
                            photo_con.Open();
                            byte[] fileBytes = System.IO.File.ReadAllBytes(item2);


                            string photoquery = @"INSERT INTO [dbo].[ArchiveImagesTBL]([bookCode],[filename],[image])
                                                                      VALUES  (@bookcode,@filename,@img)";

                            SqlCommand photo_cmd = new SqlCommand(photoquery, photo_con);

                            photo_cmd.Parameters.AddWithValue("bookcode", directoryName);
                            photo_cmd.Parameters.AddWithValue("filename", fileName);

                            photo_cmd.Parameters.AddWithValue("img", fileBytes);

                            photo_cmd.ExecuteNonQuery();
                            photo_con.Close();

                        }
                        //go to next dir



                    }
                    MessageBox.Show("done");
                }
            }

        }

        private void BTN_upload_Click(object sender, EventArgs e)
        {

        }
    }
}
