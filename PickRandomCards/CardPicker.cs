﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{   
    internal class CardPicker
    {
        private static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit(); 
            }
            return pickedCards;
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }

        private static string RandomSuit()
        {
            //get a random number from 1 to 4
            int value = random.Next(1, 5);
            //if its 1 return the string Spades
            if (value == 1) return "Spades";
            //if its 2 return the string Hearts
            if (value == 2) return "Hearts";
            //if its 3 return the string Clubs
            if (value == 3) return "Clubs";
            //If haven't returned yet, return the string Diamonds
            return "Diamonds";
        }
    }
}
