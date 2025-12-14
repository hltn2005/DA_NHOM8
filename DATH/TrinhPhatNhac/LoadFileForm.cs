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
        // Nút mở thư mục và lấy đường dẫn
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            // mở hộp thoại lấy đường dẫn
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    checkFolder= true;
                    // lưu đường dẫn người dùng đã chọn vào setting
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
        // Phương thức trả về đường dẫn
        public LinkedListFilePath.LinkedListPath PATH()
        {
            return pathList;
        }
        //Phương thức kiểm tra đường dẫn
        public bool CheckFolder()
        {
            return checkFolder;
        }
    }
}
