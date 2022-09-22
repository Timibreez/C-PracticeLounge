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

            //try
            //{
            //    Console.Write("Enter numerator: ");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter Denominator: ");
            //    int dum = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(num / dum);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Student student1 = new Student("Nonye", "Physics", 3.6);
            //Student student2 = new Student("Damola", "Elect Elect", 2.8);


            //Console.WriteLine(student1.HasHonours());
            //Console.WriteLine(student2.HasHonours());


            //Movie avengers = new Movie("The Avengers", "Timibreez", "R");
            //Movie shrek = new Movie("The Shrek", "Nonye", "VR");

            //avengers.Rating = "shgha";

            //Console.WriteLine(shrek.Rating);

            Song organize = new Song("Organize", "Asake", 60);
            Console.WriteLine(organize.getSongCount());

            Song mercy = new Song("Mercy", "Asake", 40);
            Console.WriteLine(mercy.getSongCount());

            Console.ReadLine();
        }
    }
}
