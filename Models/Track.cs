using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium_s16536.Models
{
    public class Track
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTrack { get; set; }

        [Required]
        [MaxLength(20)]
        public string TrackName { get; set; }

        [Required]
        public float Duration { get; set; }

        [ForeignKey("MusicAlbum")]
        public int IdMusicAlbum { get; set; }

        public Album MusicAlbum { get; set; }
    }
}
