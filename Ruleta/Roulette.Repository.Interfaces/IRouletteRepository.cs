using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette.Repository.Interfaces
{
    public interface IRouletteRepository
    {
        Entities.Roulette GetByIdRoulette(Entities.Roulette roulette);
        List<Entities.Roulette> GetAllRoulettes();
        Entities.Roulette UpdateIdRoulette(Entities.Roulette roulette);
        Entities.Roulette Save(Entities.Roulette roulette);
    }
}
