using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class LoadFileForm : Form
    {
        DoubleLinkedList.DoubleLinkedListSong songList;
        private bool check = false;
        public LoadFileForm()
        {
            InitializeComponent();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog folderDialog=new FolderBrowserDialog())
            {
                if(folderDialog.ShowDialog() == DialogResult.OK)
                { 
                    songList = new DoubleLinkedList.DoubleLinkedListSong(); 
                    string folderPath=folderDialog.SelectedPath;
                    string[] files=Directory.GetFiles(folderPath,"*.mp3");
                    if (files.Length > 0)
                    {
                        foreach (string file in files)
                        {
                            songList.AddLast(file);
                        }
                    }
                }
                check = true;
                
            }
        }

        private void btnMoApp_Click(object sender, EventArgs e)
        {
            if (check)
            {
                MainForm mainform = new MainForm(songList, this);
                mainform.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Đường dẫn đến folder chưa được bổ sung hoặc sai đường dẫn",
                    "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
