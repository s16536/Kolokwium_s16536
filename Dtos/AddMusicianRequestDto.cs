using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium_s16536.Models;

namespace Kolokwium_s16536.Dtos
{
    public class AddMusicianRequestDto
    {
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(20)]
        public string NickName { get; set; }

        public Track Track { get; set; }

    }

    public class Track
    {
        public int? IdTrack { get; set; }

        public string TrackName { get; set; }

        public float Duration { get; set; }

        public int? IdMusicAlbum { get; set; }
    }
}
