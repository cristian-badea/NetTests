using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Consideram urmatoarea ierarhie pentru recunoastere: Chinta Culoare, Careu, Full, Culoare, Chinta, Cui, Doua Perechi, O Pereche, Nimic */

namespace Poker
{
    public class HandDiscriminator
    {
        public HandType GetHandType(Card[] cards)
        {
            //verificam chinta culoare
            var sortedcards = cards.OrderBy(card => card.valoare);
            var pairs = sortedcards.ConsecutivePairs();
            var ischinta = pairs.All(pair => (pair.Item2.valoare - pair.Item1.valoare == 1));

            var cardsValues = cards.Select(card => card.valoare).ToArray();
            var distinctSimbols = cards.Select(card => card.simbol).Distinct();
            var isCuloare = distinctSimbols.Count() == 1;

            if (isCuloare & ischinta)
            {
                return HandType.ChintaCuloare;
            }

            //verificam Careu
            var cardValueGroups = cards.GroupBy(card => card.valoare);
            var careu = cardValueGroups.Where(cardGroup => cardGroup.Count() == 4);
            
            if (careu.Count() == 1)
            {
                return HandType.Careu;
            }

            //verificam full
            var pairedCardGroups = cardValueGroups.Where(cardGroup => cardGroup.Count() == 2);
            var cuie = cardValueGroups.Where(cardGroup => cardGroup.Count() == 3);

            if (cuie.Count() == 1)
            {
                if (pairedCardGroups.Count() == 1)
                {
                    return HandType.Full;
                }
                
            }

            //verificam culoare
            if (isCuloare)
            {
                return HandType.Culoare;
            }

            //verificam chinta
            if (ischinta)
            {
                return HandType.Chinta;
            }

            //verificam Cui
            if (cuie.Count() == 1)
            {
                return HandType.Cui;
            }

            //verificam 2 perechi
            if (pairedCardGroups.Count() == 2)
            {
                return HandType.DouaPerechi;
            }

           //verificam 1 pereche

            if (pairedCardGroups.Count() == 1)
            {
                return HandType.Pereche;
            }
            
            //daca am ajuns aici , atunci avem nimic
            return HandType.Nimic;
        }
    }
    public enum HandType
    {
        ChintaCuloare, 
        Careu, 
        Full, 
        Culoare, 
        Chinta, 
        Cui, 
        DouaPerechi, 
        Pereche, 
        Nimic
    }
}
