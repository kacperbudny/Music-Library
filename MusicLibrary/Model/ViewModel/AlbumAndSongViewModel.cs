using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibrary.Model.ViewModel
{
    public class AlbumAndSongViewModel
    {
        public Album AlbumObj { get; set; }
        public IEnumerable<Song> Songs { get; set; }
    }
}
