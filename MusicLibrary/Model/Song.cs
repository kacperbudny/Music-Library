using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibrary.Model
{
    public class Song
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int TrackNumber { get; set; }

        public int AlbumId { get; set; }

        [ForeignKey("AlbumId")]
        public virtual Album Album { get; set; }
    }
}
