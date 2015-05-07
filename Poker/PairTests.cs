using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

namespace Poker
{
    public class PairTests
    {
        public void Pairs()
        {
            var list = new[] { 1, 2, 3 };
            var pairs = list.ConsecutivePairs();

            pairs.Count().ShouldBe(2);

            pairs.ElementAt(0).ShouldBe(new Tuple<int, int>(1, 2));
            pairs.ElementAt(1).ShouldBe(new Tuple<int, int>(2, 3));
        }
    }
}
