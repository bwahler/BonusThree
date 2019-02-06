using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus3
{
    class NumberGuesser
    {
        public static void NumberGuess()
        {
            int computerNumber = GetNumber(0, 100);
            string message = "Give me a number between 0 and 100!";
            int count = 1;
            int userNumber = GetUserNumber(message, 0, 100);
            int difference = DoSubtraction(userNumber, computerNumber);

            bool run = true;
            while (run == true)
            {
                while (difference != 0)
                {
                    count++;
                    message = EvaluateNumber(userNumber);
                    userNumber = GetUserNumber(message, 0, 100);
                    difference = DoSubtraction(userNumber, computerNumber);
                    Console.WriteLine(message);
                    ReturnFinalMessage(count);
                }
                run = PlayAgain();
            }
        }

        public static string EvaluateNumber(int number)
        {
            string message;
            if (number > 0)
            {
                if (number >= 10)
                {
                    message = "Way High!";
                }
                else
                {
                    message = "Super High!";
                }
            }
            else
            {
                if (number < -10)
                {
                    message = "Way Low!";
                }
                else
                {
                    message = "Low!";
                }
            }
            return message;
        }

        public static int DoSubtraction(int number1, int number2)
        {
            return number1 - number2;
        }

        public static int GetNumber(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }

        public static void ReturnFinalMessage(int number)
        {
            if (number == 1)
            {
                Console.WriteLine("Yaaaaaassssssssssssssssssssss!!!! Guessed in 1 try!");
            }
            else
            {
                Console.WriteLine($"Yaaaaaassssssssssssssssssssss!!!! Guessed in {number} of tries!");
            }
        }

        public static int GetUserNumber(string message, int min, int max)
        {
            int userNumber = min - 1;

            if (userNumber < min || userNumber > max)
            {
                Console.WriteLine(message);
                while (!int.TryParse(Console.ReadLine(), out userNumber)) ;
            }
            return userNumber;
        }

        public static bool PlayAgain()
        {
            Console.WriteLine("Would you like to play again?");
            string userContinue = Console.ReadLine().ToLower();
            bool run;
            if (userContinue == "y")
            {
                run = true;
            }
            else if (userContinue == "n")
            {
                run = false;
            }
            else
            {
                run = PlayAgain();
            }
            return run;
        }
    }
}
