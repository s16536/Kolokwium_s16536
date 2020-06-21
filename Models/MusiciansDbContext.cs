using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium_s16536.Models
{
    public class MusiciansDbContext : DbContext
    {

        public MusiciansDbContext() { }

        public MusiciansDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Musician> Musician { get; set; }

        public DbSet<Track> Track { get; set; }

        public DbSet<Album> Album { get; set; }

        public DbSet<MusicLabel> MusicLabel { get; set; }

        public DbSet<MusicianTrack> Musician_Track { get; set; }


    }
}
