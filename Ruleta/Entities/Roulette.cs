using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    [Serializable]
    public class Roulette
    {
        public string Id;
        public bool IsOpen = false;
        private List<Bets> ListBest;

        public void AddBet(Bets bets)
        {
            if (ListBest == null)
            {
                ListBest = new List<Bets>();
                ListBest.Add(bets);
            }
            else
            {
                ListBest.Add(bets);
            }
        }


    }
}
