using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    internal class CardPicker
    {
        private static Random random = new Random();

        /// <summary>
        /// Escolha um número de cartas e retorne-as
        /// </summary>
        /// <param name="numberOfCards">O nunmero de cartas para escolher</param>
        /// <returns>Um array de srtings com os nomes das cartas</returns>
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];

            for (int i = 0; i < numberOfCards; i++) 
            {
                pickedCards[i] = $"{RandomValue()} of {RandomSuit()}";
            }
            return pickedCards;

        }

        /// <summary>
        /// Retorna a figura de carta
        /// </summary>
        /// <returns>Uma string</returns>
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

        /// <summary>
        /// Retorna o naipe conforme a posicao no array
        /// </summary>
        /// <returns>Uma string do array</returns>
        private static string RandomSuit()
        {
            int value = random.Next(0, 4);

            string[] suits = new string[]{"Spades", "Hearts", "Clubs", "Diamonds"};

            return suits[value];
        }

    }
}
