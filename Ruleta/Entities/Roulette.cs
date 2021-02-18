using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Roulette
    {
        private int _id;
        private bool _state;
        private List<Bets> _listBest;

        public Roulette(int id, bool condition)
        {
            this._id = id;
            this._state = condition;
        }

        public int GetId()
        {
            return this._id;
        }

        public bool GetCondition()
        {
            return this._state;
        }

        public List<Bets> GetListBest()
        {
            return _listBest;
        }

        public void SetId(int id)
        {
            this._id = id;
        }

        public void GetCondition(bool condition)
        {
            this._state = condition;
        }

        private void AddBest(Bets bets)
        {
            if (this._listBest == null)
            {
                this._listBest = new List<Bets>();
                _listBest.Add(bets);
            }
            else
                _listBest.Add(bets);
        }

    }
}
