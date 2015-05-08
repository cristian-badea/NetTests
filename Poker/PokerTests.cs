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
            Card[] cards = new Card[] 
            {
                new Card(1,CardSimbol.Pica),
                new Card(2,CardSimbol.Trefla),
                new Card(2,CardSimbol.Pica),
                new Card(4,CardSimbol.Pica),
                new Card(5,CardSimbol.Pica),
            };
            var handType=handDiscriminator.GetHandType(cards);
            handType.ShouldBe(HandType.Pereche);
        }

        public void TwoPairs()
        {
            var handDiscriminator = new HandDiscriminator();
            Card[] cards = new Card[] 
            {
                new Card(1,CardSimbol.Pica),
                new Card(2,CardSimbol.Pica),
                new Card(2,CardSimbol.Romb),
                new Card(4,CardSimbol.Pica),
                new Card(4,CardSimbol.Pica),
            };
            var handType = handDiscriminator.GetHandType(cards);
            handType.ShouldBe(HandType.DouaPerechi);
        }

        public void Cui()
        {
            var handDiscriminator = new HandDiscriminator();
            Card[] cards = new Card[] 
            {
                new Card(2,CardSimbol.Pica),
                new Card(2,CardSimbol.Pica),
                new Card(2,CardSimbol.Inima),
                new Card(4,CardSimbol.Pica),
                new Card(5,CardSimbol.Pica),
            };
            var handType = handDiscriminator.GetHandType(cards);
            handType.ShouldBe(HandType.Cui);   
        }

        public void Fullhouse()
        {
            var handDiscriminator = new HandDiscriminator();
            Card[] cards = new Card[] 
            {
                new Card(2,CardSimbol.Pica),
                new Card(2,CardSimbol.Pica),
                new Card(2,CardSimbol.Pica),
                new Card(4,CardSimbol.Pica),
                new Card(4,CardSimbol.Pica),
            };
            var handType = handDiscriminator.GetHandType(cards);
            handType.ShouldBe(HandType.Full);   
        }

        public void TestCareu()
        {
            var handDiscriminator = new HandDiscriminator();
            Card[] cards = new Card[] 
            {
                new Card(3,CardSimbol.Pica),
                new Card(3,CardSimbol.Pica),
                new Card(3,CardSimbol.Pica),
                new Card(3,CardSimbol.Pica),
                new Card(5,CardSimbol.Pica),
            };
            var handType = handDiscriminator.GetHandType(cards);
            handType.ShouldBe(HandType.Careu);   
        }

        public void TestChinta()
        {
            var handDiscriminator = new HandDiscriminator();
            Card[] cards = new Card[] 
            {
                new Card(2,CardSimbol.Pica),
                new Card(3,CardSimbol.Trefla),
                new Card(1,CardSimbol.Pica),
                new Card(5,CardSimbol.Romb),
                new Card(4,CardSimbol.Pica),
            };
            var handType = handDiscriminator.GetHandType(cards);
            handType.ShouldBe(HandType.Chinta); 

        }

        public void Culoare()
        {
            Card[] cards = new Card[] 
            {
                new Card(2,CardSimbol.Pica),
                new Card(1,CardSimbol.Pica),
                new Card(5,CardSimbol.Pica),
                new Card(8,CardSimbol.Pica),
                new Card(6,CardSimbol.Pica),
            };

            var handDiscriminator = new HandDiscriminator();
            var handType = handDiscriminator.GetHandType(cards);

            handType.ShouldBe(HandType.Culoare);
        }
        public void ChintaCuloare()
        {
            Card[] cards = new Card[] 
            {
                new Card(1,CardSimbol.Pica),
                new Card(2,CardSimbol.Pica),
                new Card(3,CardSimbol.Pica),
                new Card(4,CardSimbol.Pica),
                new Card(5,CardSimbol.Pica),
            };
            var handDiscriminator = new HandDiscriminator();
            var handType = handDiscriminator.GetHandType(cards);

            handType.ShouldBe(HandType.ChintaCuloare);
        }
        public void Nimic()
        {
            Card[] cards = new Card[] 
            {
                new Card(1,CardSimbol.Pica),
                new Card(5,CardSimbol.Romb),
                new Card(3,CardSimbol.Trefla),
                new Card(4,CardSimbol.Pica),
                new Card(13,CardSimbol.Inima),
            };
            var handDiscriminator = new HandDiscriminator();
            var handType = handDiscriminator.GetHandType(cards);

            handType.ShouldBe(HandType.Nimic);
        }
    }
}
