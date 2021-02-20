using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette.Bussines.Interfaces
{
    public interface IRouletteBussines
    {
        string CreateRoulette();
        bool OpenRulette(string IdRulette);
    }
}
