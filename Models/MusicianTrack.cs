using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium_s16536.Models
{
    public class MusicianTrack
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMusicianTrack { get; set; }

        [Required]
        [ForeignKey("Track")]
        public int IdTrack { get; set; }

        public Track Track { get; set; }

        [Required]
        [ForeignKey("Musician")]
        public int IdMusician { get; set; }

        public Musician Musician { get; set; }
    }
}
