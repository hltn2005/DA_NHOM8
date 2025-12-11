using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btnPlaylist_Click(object sender, EventArgs e)
		{
			PlaylistManagerForm ql= new PlaylistManagerForm();
			ql.ShowDialog();
		}

		private void btnPlaylistManager_Click(object sender, EventArgs e)
		{
			PlaylistManagerForm qlPlaylist = new PlaylistManagerForm();
			qlPlaylist.ShowDialog();
		}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {

        }
    }
}
