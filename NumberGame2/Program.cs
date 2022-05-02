using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Random rn = new Random();
            Console.WriteLine("Please set your number parameters.");
            Console.Write("Low: ");
            string lo = Console.ReadLine();
            int loi = Convert.ToInt32(lo);
            Console.WriteLine();
            Console.Write("High: ");
            string hi = Console.ReadLine();
            int hii = Convert.ToInt32(hi);
            Console.Clear();
            int ran = rn.Next(loi, hii);
            int guessint;
            Console.WriteLine("Guess a number!");
            int guesscount = 1;
            do
            {
                Console.Write("Guess: ");
                string guess = Console.ReadLine();
                guessint = Convert.ToInt32(guess);
                Console.Clear();
                if (guessint == ran)
                {
                    Console.WriteLine("Correct!");
                    break;
                }
                else if (guessint > ran)
                {
                    Console.WriteLine("Lower!");
                    guesscount++;
                }
                else if (guessint < ran)
                {
                    Console.WriteLine("Higher!");
                    guesscount++;
                }
            } while (guessint != ran);
            Console.WriteLine("It took you " + guesscount + " guesses!");
            Console.ReadKey();
        }
    }
}
