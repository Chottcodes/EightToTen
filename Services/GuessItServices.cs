using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightToTen.Services
{
    public class GuessItServices
    {
        public string EasyGuess(string GuessEasy)
        {
            int num1 = 0;
            bool validnumber = int.TryParse(GuessEasy, out num1);
            if (validnumber == false || num1 == 0 || num1 > 101)
            {
                return "Please Enter A Number between 1-10";
            }
            Random random = new Random();
            int randomEasyNumber = random.Next(1, 11);
            if (num1 > randomEasyNumber)
            {
                return $"Your Guess is to High the correct number is {randomEasyNumber}";
            }
            if (num1 < randomEasyNumber)
            {
                return $"Your Guess is to Low the correct number is {randomEasyNumber}";
            }
            else
            {
                return "Bulleye";
            }
        }
        public string MediumGuess(string GuessMedium)
        {
             int num1 = 0;
            bool validnumber = int.TryParse(GuessMedium, out num1);
            if (validnumber == false || num1 == 0 || num1 > 101)
            {
                return "Please Enter A Number between 1-50";
            }
            Random random = new Random();
            int randomMediumNumber = random.Next(1, 51);
            if (num1 > randomMediumNumber)
            {
                return $"Your Guess is to High the correct number is {randomMediumNumber}";
            }
            if (num1 < randomMediumNumber)
            {
                return $"Your Guess is to Low the correct number is {randomMediumNumber}";
            }
            else
            {
                return "Bulleye";
            }
        }
         public string HardGuess(string GuessHard)
        {
             int num1 = 0;
            bool validnumber = int.TryParse(GuessHard, out num1);
            if (validnumber == false || num1 == 0 || num1 > 101)
            {
                return "Please Enter A Number between 1-100";
            }
            Random random = new Random();
            int randomHardNumber = random.Next(1, 101);
            if (num1 > randomHardNumber)
            {
                return $"Your Guess is to High the correct number is {randomHardNumber}";
            }
            if (num1 < randomHardNumber)
            {
                return $"Your Guess is to Low the correct number is {randomHardNumber}";
            }
            else
            {
                return "Bulleye";
            }
        }

    }
}