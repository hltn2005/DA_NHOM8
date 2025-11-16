using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;

namespace GiaoDien
{
    public partial class AddSongForm : Form
    {
        List<Song> songList= new List<Song>();
        public AddSongForm(DoubleLinkedList.DoubleLinkedListSong list)
        {
            InitializeComponent();
            songList=list.ConvertToList();
            dgvPlayList.DataSource = songList;
            dgvPlayList.AutoGenerateColumns=false;
        }
        
    }
}
