using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GuessingGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberRandom = new Random();
            Console.WriteLine("My number guessing game");
            Console.WriteLine("\nLevels of difficulty available: E- Easy, M- Medium, H- Hard");
            Console.Write("Which level of difficulty do you prefer: ");
            string userGuess = Console.ReadLine();
            if (userGuess == "E")
            {
                Console.WriteLine("\nYou have selected easy: You have to guess a number between 1 to 10");
                int i = 0;
                int a;
                while (i <= 5)
                {
                    numberRandom.Next(1, 11);
                    Console.WriteLine("\nYou have {0} chances left", a = 6- i);
                    Console.Write("Guess a number: ");
                    int guessNumber =Convert.ToInt32(Console.ReadLine());
                    if (guessNumber==numberRandom.Next(1, 11))
                    {
                        Console.WriteLine("You're Right!");
                    }
                    else
                    {
                        Console.WriteLine("You're Wrong!");
                    }
                    i++;
                }
                Console.WriteLine("\nGame Over!");
            }
            if (userGuess == "M")
            {
                Console.WriteLine("\nYou have selected medium: You have to guess a number between 1 to 20");
                int i = 0;
                int a;
                while (i <= 3)
                {
                    numberRandom.Next(1, 11);
                    Console.WriteLine("\nYou have {0} chances left", a = 4 - i);
                    Console.Write("Guess a number: ");
                    int guessNumber = Convert.ToInt32(Console.ReadLine());
                    if (guessNumber == numberRandom.Next(1, 21))
                    {
                        Console.WriteLine("You're Right!");
                    }
                    else
                    {
                        Console.WriteLine("You're Wrong!");
                    }
                    i++;
                }
                Console.WriteLine("\nGame Over!");
            }
            if (userGuess == "H")
            {
                Console.WriteLine("\nYou have selected easy: You have to guess a number between 1 to 50");
                int i = 0;
                int a;
                while (i <= 2)
                {
                    numberRandom.Next(1, 11);
                    Console.WriteLine("\nYou have {0} chances left", a = 3 - i);
                    Console.Write("Guess a number: ");
                    int guessNumber = Convert.ToInt32(Console.ReadLine());
                    if (guessNumber == numberRandom.Next(1, 51))
                    {
                        Console.WriteLine("You're Right!");
                    }
                    else
                    {
                        Console.WriteLine("You're Wrong!");
                    }
                    i++;
                }
                Console.WriteLine("\nGame Over!");
            }
        }
    }
}