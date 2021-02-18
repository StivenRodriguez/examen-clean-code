using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public enum Color
    {
        rojo,
        verde
    }

    public class Bets
    {
        private User _user;
        private Color _color;
        private int _betNumber;
        private Double _betValue;

        public Bets(User user, Color color, int betNumber, Double betValue)
        {
            this._user = user;
            this._color = color;
            this._betNumber = betNumber;
            this._betValue = betValue;
        }

        public User GetUser()
        {
            return this._user;
        }

        public Color GetColor()
        {
            return this._color;
        }

        public int GetBetNumber()
        {
            return this._betNumber;
        }

        public Double GetBetValue()
        {
            return this._betValue;
        }

        public void SetUser(User user)
        {
            this._user = user;
        }

        public void  SetColor(Color color)
        {
            this._color = color;
        }

        public void SetBetNumber(int betNumber)
        {
            this._betNumber = betNumber;
        }

        public void SetBetValue(double betValue)
        {
            this._betValue = betValue;
        }



    }
}
