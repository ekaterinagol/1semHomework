using CardsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsLibrary
{
    public class Card
    {
        public SuitType Suit;
        public int Value { get; set; }

        public Card(SuitType cardSuit, int cardValue)
        {
            Suit = cardSuit;
            Value = cardValue;
        }


        public bool IsCardTheSameValue(Card card1, Card card2)
        {
            if (card1.Value == card2.Value) return true;

            return false;
        }

        public Card GenerateCard()
        {
            Random rnd = new Random();
            int value = rnd.Next(6, 15);
            Card card = new Card(cardSuitType[rnd.Next(1, 5)], value);
            return card;

        }

        public Stack<Card>[] GenerateStacks() 
        {
            Stack<Card>[] stack = new Stack<Card>[9];
            for (int j = 0; j < 9; j++)
            {
                Stack<Card> stackAdditional = new Stack<Card>();
                stack[j] = stackAdditional;
                for (int i = 0; i < 4; i++)
                {
                    for (int k = 0; k < j + 1; k++)
                    {
                        var card = GenerateCard();
                        if (stack[k].Contains(card))
                            i--;
                        else
                            stackAdditional.Push(card);

                    }
                }
                stack[j] = stackAdditional;
            }
            return stack;
        }



        static Dictionary<int,SuitType> cardSuitType = new Dictionary<int, SuitType>
        {
            {1, SuitType.C},
            {2, SuitType.D},
            {3, SuitType.H},
            {4, SuitType.S}

        };


        public static Dictionary<SuitType, string> stringCardSuitType = new Dictionary<SuitType, string>
        {
            {SuitType.C, "C" },
            {SuitType.D, "D" },
            {SuitType.H, "H" },
            {SuitType.S, "S"}
        };

    }
}
