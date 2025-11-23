using TrinhPhatNhac.Properties;
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

namespace TrinhPhatNhac
{
    public partial class LoadFileForm : Form
    {
        LinkedListFilePath.LinkedListPath pathList=new LinkedListFilePath.LinkedListPath();
        public LoadFileForm(LinkedListFilePath.LinkedListPath PathList)
        {
            InitializeComponent();
            pathList = PathList;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.SongFolderPath = folderDialog.SelectedPath;
                    Properties.Settings.Default.Save();
                    string folderPath = folderDialog.SelectedPath;
                    string[] files = Directory.GetFiles(folderPath, "*.mp3");
                    if (files.Length > 0)
                    {
                        foreach (string file in files)
                        {
                            pathList.AddLast(file);
                        }
                    }

                    
                }

            }
        }

        
    }
}
