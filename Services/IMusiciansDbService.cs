using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium_s16536.Dtos;
using Kolokwium_s16536.Models;

namespace Kolokwium_s16536.Services
{
    public interface IMusiciansDbService
    {
        public Musician GetMusician(int id);

        public Musician AddMusician(AddMusicianRequestDto request);
    }
}
