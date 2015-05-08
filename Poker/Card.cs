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
        public CardSimbol simbol;

        public Card(int valoare, CardSimbol simbol)
        {
            this.valoare = valoare;
            this.simbol = simbol;
        }
    }

    public enum CardSimbol
    {
        Pica,
        Romb,
        Trefla,
        Inima
    };
}
