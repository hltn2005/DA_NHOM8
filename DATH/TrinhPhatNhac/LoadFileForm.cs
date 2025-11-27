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
        public bool checkFolder=false;
        public LoadFileForm()
        {
            InitializeComponent();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())// mở hộp thoại lấy đường dẫn
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // lưu đường dẫn người dùng đã chọn vào setting
                    checkFolder= true;
                    Properties.Settings.Default.SongFolderPath = folderDialog.SelectedPath;
                    Properties.Settings.Default.Save();
                    string folderPath = folderDialog.SelectedPath;// lấy đường dẫn vừa chọn
                    string[] files = Directory.GetFiles(folderPath, "*.mp3");// lấy tất cả file mp3 trong đường dẫn 
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
        public LinkedListFilePath.LinkedListPath PATH()
        {
            return pathList;
        }
        public bool CheckFolder()
        {
            return checkFolder;
        }
        private void LoadFileForm_Load(object sender, EventArgs e)
        {

        }
    }
}
