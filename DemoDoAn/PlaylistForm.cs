using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDoAn
{
	public partial class PlaylistForm : Form
	{
		public PlaylistForm()
		{
			InitializeComponent();
		}

		private void btnPlaylistManager_Click(object sender, EventArgs e)
		{
			PlaylistManagerForm qlPlaylist = new PlaylistManagerForm();
			qlPlaylist.Show();
		}
	}
}
