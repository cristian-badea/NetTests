using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class HandDiscriminator
    {
        public string GetHandType(Card[] cards)
        {
            var cardGroups = cards.GroupBy(card => card.valoare);
            var pairedCardGroups = cardGroups.Where(cardGroup => cardGroup.Count() == 2);

            if (pairedCardGroups.Count() == 2)
            {
                return "Two Pairs";
            }

            var cuie = cardGroups.Where(cardGroup => cardGroup.Count() == 3);

            if (cuie.Count() == 1)
            {
                if (pairedCardGroups.Count() == 1)
                {
                    return "FullHouse";
                }
                return "Cui";
            }

            if (pairedCardGroups.Count() == 1)
            {
                return "One Pair";
            }

            var careu = cardGroups.Where(cardGroup => cardGroup.Count() == 4);
            if (careu.Count() == 1)
            {
                return "Careu";
            }

            var sortedcards = cards.OrderBy(card => card.valoare);
            var pairs = sortedcards.ConsecutivePairs();
            var ischinta = pairs.All(pair => (pair.Item2.valoare - pair.Item1.valoare == 1));

            var cardsValues = cards.Select(card => card.valoare).ToArray();
            var distinctSimbols = cards.Select(card => card.simbol).Distinct();
            var isCuloare = distinctSimbols.Count() == 1;
           
            if(isCuloare & ischinta)
            {
                return "Chinta Culoare";
            }
            
            if (isCuloare)
            {
                return "Culoare";
            }

            if (ischinta)
            {
                return "Chinta";
            }


            return "nimic";

        }
    }
}
