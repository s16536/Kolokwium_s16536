using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium_s16536.Dtos;
using Kolokwium_s16536.Models;
using Track = Kolokwium_s16536.Models.Track;

namespace Kolokwium_s16536.Services
{
    public class EfMusiciansDbService : IMusiciansDbService
    {

        private readonly MusiciansDbContext _context;

        public EfMusiciansDbService(MusiciansDbContext context)
        {
            _context = context;
        }

        public Musician GetMusician(int id)
        {
            return _context.Musician.Find(id);
        }

        public Musician AddMusician(AddMusicianRequestDto request)
        {
            var track = GetOrCreateTrack(request.Track);

            var musician = new Musician()
            {
                FirstName = request.FirstName,
                LastName =  request.LastName,
                NickName = request.NickName
            };

            _context.Add(musician);

            if (track != null)
            {
                _context.Musician_Track.Add(new MusicianTrack()
                {
                    Musician = musician,
                    Track = track
                });
            }

            try
            {
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return null;
            }

            return musician;
        }

        private Track GetOrCreateTrack(Dtos.Track requestTrack)
        {
            if (requestTrack == null)
            {
                return null;
            }

            Track track = null;
            if (requestTrack.IdTrack != null)
            {
                track = _context.Track.Find(requestTrack.IdTrack);
            }

            if (track == null)
            {
                track = _context.Track.FirstOrDefault(t =>
                    (t.TrackName == requestTrack.TrackName && t.Duration == requestTrack.Duration && t.IdMusicAlbum == requestTrack.IdMusicAlbum));
            }

            if (track == null && requestTrack.IdMusicAlbum != null)
            {
                track = new Track()
                {
                    Duration = requestTrack.Duration,
                    IdMusicAlbum = (int) requestTrack.IdMusicAlbum,
                    TrackName = requestTrack.TrackName
                };
                _context.Track.Add(track);
            }

            return track;

        }
    }
}
