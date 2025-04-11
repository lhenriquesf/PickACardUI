using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    internal class CardPicker
    {
        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];

            for (int i = 0; i < numberOfCards; i++) 
            {
                pickedCards[i] = $"{RandomValue()} of {RandomSuit()}";
            }
            return pickedCards;

        }


        private static string RandomValue()
        {
            int value = random.Next(1, 14);

            switch (value) 
            {
                case 1: return "Ace";

                case 11: return "Jack";

                case 12: return "Queen";

                case 13: return "King";

                default: return value.ToString();
            }   
        }


        private static string RandomSuit()
        {
            int value = random.Next(0, 4);

            string[] suits = new string[]{"Spades", "Hearts", "Clubs", "Diamonds"};

            return suits[value];
        }


    }
}
