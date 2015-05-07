using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class HandDiscriminator
    {
        public string GetHandType(int[] hand)
        {
            var cardGroups = hand.GroupBy(card => card);
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

            var sortedcards = hand.OrderBy(card => card);
            var pairs = sortedcards.ConsecutivePairs();
            var ischinta = pairs.All(pair => (pair.Item2 - pair.Item1 == 1));

            if (ischinta)
            {
                return "Chinta";
            }


            throw new NotImplementedException();

        }

        public string GetHandType(Card[] cards)
        {
            var cardsValues = cards.Select(card => card.valoare).ToArray();
            var distinctSimbols = cards.Select(card => card.simbol).Distinct();
            if (distinctSimbols.Count() == 1)
            {
                if (GetHandType(cardsValues) == "Chinta")
                {
                    return "Chinta Culoare";
                }
                return "Culoare";
            }
            throw new NotImplementedException();
        }
    }
}
