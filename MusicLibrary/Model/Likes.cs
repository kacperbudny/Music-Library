using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibrary.Model
{
    public class Likes
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public string UserId { get; set; }

        [ForeignKey("AlbumId")]
        public virtual Album Album { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
