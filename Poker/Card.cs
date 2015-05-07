using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Card
    {
        public int valoare;
        public string simbol;

        public Card(int valoare, string simbol)
        {
            this.valoare = valoare;
            this.simbol = simbol;
        }
    }
}
