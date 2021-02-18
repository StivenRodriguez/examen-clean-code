using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class User
    {
        private int _id;
        private string _name;
        private Double _credit;
        private readonly Double maxBetValue = 10000;

        public User(int id, string name, Double credit)
        {
            this._id = id;
            this._name = name;
            this._credit = credit;
        }

        public int GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public Double GetCredit()
        {
            return _credit;
        }

        public void SetId(int id)
        {
            this._id = id;
        }

        public void SetName(string name)
        {
            this._name = name;
        }

        public void SetCredit(Double credit)
        {
            this._credit = credit;
        }

        public Boolean CreditNecessary(Bets bets)
        {
            return bets.GetBetValue() > maxBetValue;
        }



    }
}
