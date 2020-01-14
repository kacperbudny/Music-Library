using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibrary.Model
{
    public class Album
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Artist { get; set; }

        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
    }
}
