using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLounge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string secretWord = "timibreez";
            //string guessedWord = "";
            //bool outOfGuesses = false;
            //int guessCount = 0;
            //int guessLimit = 3;

            //while (guessedWord != secretWord && !outOfGuesses)
            //{
            //    if(guessCount < guessLimit)
            //    {
            //        Console.WriteLine("Enter a word");
            //        guessedWord = Console.ReadLine();
            //        guessCount++;
            //    }
            //    else
            //    {
            //        outOfGuesses = true;
            //    }
            //}
            //if (outOfGuesses)
            //{
            //    Console.WriteLine("You Lose");
            //}else
            //{
            //    Console.WriteLine("You Win");
            //}

            //int[,] numGrid =
            //{
            //    { 1, 2 },
            //    {3,  4 },
            //    {6, 5 },
            //};

            //Console.WriteLine(numGrid[1, 1]);

            try
            {
                Console.Write("Enter numerator");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Denominator");
                int dum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num / dum);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
