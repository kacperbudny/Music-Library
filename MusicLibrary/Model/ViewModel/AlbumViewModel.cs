using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibrary.Model.ViewModel
{
    public class AlbumViewModel
    {
        public List<Album> AlbumList { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
