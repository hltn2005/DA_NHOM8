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
		DoubleLinkedList.DoubleLinkedListSong songList;
		public PlaylistForm(DoubleLinkedList.DoubleLinkedListSong list)
		{
			InitializeComponent();
			songList = list;
		}

		private void btnPlaylistManager2_Click(object sender, EventArgs e)
		{
			PlaylistManagerForm qlPlaylist = new PlaylistManagerForm();
			qlPlaylist.ShowDialog();
		}

        private void btnAddSong_Click(object sender, EventArgs e)
        {
			AddSongForm addSongForm = new AddSongForm(songList);
			addSongForm.ShowDialog();
        }
    }
}
