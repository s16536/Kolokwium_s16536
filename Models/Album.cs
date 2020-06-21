using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium_s16536.Models
{
    public class Album
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAlbum { get; set; }

        [Required]
        [MaxLength(30)]
        public string AlbumName { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }


        [ForeignKey("MusicLabel")]
        public int IdMusicLabel { get; set; }

        public MusicLabel MusicLabel { get; set; }
    }
}
