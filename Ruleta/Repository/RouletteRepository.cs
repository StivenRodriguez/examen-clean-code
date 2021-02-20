using EasyCaching.Core;
using Roulette.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roulette.Repository
{
    public class RouletteRepository : IRouletteRepository
    {
        private IEasyCachingProvider cachingProvider;
        private IEasyCachingProviderFactory cachingProviderFactory;
        private string Key = "roulette";
        private const string KeyRedis = "dboRoulette";
        private TimeSpan TimeConf = TimeSpan.FromDays(30);

        public RouletteRepository(IEasyCachingProviderFactory cachingProviderFactory)
        {
            this.cachingProviderFactory = cachingProviderFactory;
            this.cachingProvider = this.cachingProviderFactory.GetCachingProvider(Key);
        }

        public Entities.Roulette GetByIdRoulette(Entities.Roulette roulette)
        {
            var item = this.cachingProvider.Get<Entities.Roulette>(KeyRedis + roulette.Id);
            if (!item.HasValue)
            {
                return null;
            }
            return item.Value;
        }

        public List<Entities.Roulette> GetAllRoulettes()
        {
            var rouletes = this.cachingProvider.GetByPrefix<Entities.Roulette>(KeyRedis);
            if (rouletes.Values.Count == 0)
            {
                return new List<Entities.Roulette> ();
            }
            return new List<Entities.Roulette> (rouletes.Select(x => x.Value.Value));
        }

        public Entities.Roulette UpdateIdRoulette(Entities.Roulette roulette)
        {
            return Save(roulette);
        }

        public Entities.Roulette Save(Entities.Roulette roulette)
        {
            cachingProvider.Set(KeyRedis + roulette.Id, roulette, TimeConf);
            return roulette;
        }
    }
}
