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
        public string Id;
        public string Iduser;
        public int BetNumber;
        public Double BetValue;
        public Double MaxBetValue = 10000;
    }
}
