using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

namespace Poker
{
    public class PokerTests
    {
        public void Test()
        {
            
        }
        public void OnePair()
        {  
            var handDiscriminator=new HandDiscriminator();
            int[] cards = new int[]
            {
                1,2,2,4,5
            };
            var handType=handDiscriminator.GetHandType(cards);
            handType.ShouldBe("One Pair");
        }

        public void TwoPairs()
        {
            var handDiscriminator = new HandDiscriminator();
            int[] cards = new int[]
            {
                1,2,2,4,4
            };
            var handType = handDiscriminator.GetHandType(cards);
            handType.ShouldBe("Two Pairs");
        }

        public void Cui()
        {
            var handDiscriminator = new HandDiscriminator();
            int[] cards = new int[]
            {
                1,2,2,2,4
            };
            var handType = handDiscriminator.GetHandType(cards);
            handType.ShouldBe("Cui");   


        }

        public void Fullhouse()
        {
            var handDiscriminator = new HandDiscriminator();
            int[] cards = new int[]
            {
                1,2,2,2,1
            };
            var handType = handDiscriminator.GetHandType(cards);
            handType.ShouldBe("FullHouse");   
        }

        public void TestCareu()
        {
            var handDiscriminator = new HandDiscriminator();
            int[] cards = new int[]
            {
                2,2,2,2,1
            };
            var handType = handDiscriminator.GetHandType(cards);
            handType.ShouldBe("Careu");   
        }

        public void TestChinta()
        {
            var handDiscriminator = new HandDiscriminator();
            int[] cards = new int[]
            {
                2,4,5,3,6
            };
            var handType = handDiscriminator.GetHandType(cards);
            handType.ShouldBe("Chinta"); 

        }

        public void Culoare()
        {
            Card[] cards = new Card[] 
            {
                new Card(2,"Pica"),
                new Card(2,"Pica"),
                new Card(5,"Pica"),
                new Card(8,"Pica"),
                new Card(6,"Pica"),
            };

            var handDiscriminator = new HandDiscriminator();
            var handType = handDiscriminator.GetHandType(cards);

            handType.ShouldBe("Culoare");
        }
        public void ChintaCuloare()
        {
            Card[] cards = new Card[] 
            {
                new Card(1,"Pica"),
                new Card(2,"Pica"),
                new Card(3,"Pica"),
                new Card(4,"Pica"),
                new Card(5,"Pica"),
            };
            var handDiscriminator = new HandDiscriminator();
            var handType = handDiscriminator.GetHandType(cards);

            handType.ShouldBe("Chinta Culoare");
        }
    }
}
