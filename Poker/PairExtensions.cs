using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public static class PairExtensions
    {
        public static IEnumerable<Tuple<T, T>> ConsecutivePairs<T>(this IEnumerable<T> list)
        {
            var previous = list.ElementAt(0);

            foreach (var item in list.Skip(1))
            {
                yield return new Tuple<T, T>(previous, item);
                previous = item;
            }
        }
    }
}
