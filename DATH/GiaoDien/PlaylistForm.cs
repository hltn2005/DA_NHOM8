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
	public partial class PlaylistForm : Form
	{
		public PlaylistForm()
		{
			InitializeComponent();
		}

		private void btnPlaylistManager2_Click(object sender, EventArgs e)
		{
			PlaylistManagerForm qlPlaylist = new PlaylistManagerForm();
			qlPlaylist.ShowDialog();
		}
	}
}
