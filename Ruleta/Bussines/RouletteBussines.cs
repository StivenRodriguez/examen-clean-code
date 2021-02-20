using Entities;
using Roulette.Bussines.Interfaces;
using Roulette.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines
{
    public class RouletteBussines : IRouletteBussines
    {
        private IRouletteRepository _rouletteRepository;
        private Entities.Roulette roulette;

        public RouletteBussines(IRouletteRepository rouletteRepository)
        {
            this._rouletteRepository = rouletteRepository;
        }

        public Entities.Roulette FindRoulette(string Id)
        {
            roulette = this._rouletteRepository.GetByIdRoulette(new Entities.Roulette { Id = Id });
            return roulette;
        }

        public string CreateRoulette()
        {
            roulette = new Entities.Roulette()
            {
                Id = Guid.NewGuid().ToString(),
                IsOpen = false,
            };
            return this._rouletteRepository.Save(roulette).Id;
        }

        public bool OpenRulette(string IdRulette)
        {
            roulette = this.FindRoulette(IdRulette);
            if (roulette == null)
            {
                //aplicar response
                return false;
            }
            roulette.IsOpen = true;
            return this._rouletteRepository.UpdateIdRoulette(roulette).IsOpen;
        }

        public bool CloseRulette(string IdRulette)
        {
            roulette = this.FindRoulette(IdRulette);
            if (roulette == null)
            {
                //aplicar response
                return false;
            }
            roulette.IsOpen = false;
            return this._rouletteRepository.UpdateIdRoulette(roulette).IsOpen;
        }


        public void CreateBest(Bets bets)
        {
            if (bets.BetValue > bets.MaxBetValue)
            {
                //aplicar response validacion
                return;
            }
            roulette = this.FindRoulette(bets.Id);
            if (roulette == null)
            {
                //aplicar response validacion
                return;
            }

            if (!roulette.IsOpen)
            {
                //aplicar response validacion
                return;
            }

            roulette.AddBet(bets);

        }


        public List<Entities.Roulette> GetAllRoullets()
        {
            return this._rouletteRepository.GetAllRoulettes();
        }

    }
}
