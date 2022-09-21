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
            do
            {
                Console.Clear();
                Console.Title = "NumberGame";
                Random rn = new Random();
                Console.WriteLine("Please set your number parameters.");
                Console.Write("Low: ");
                string lo = Console.ReadLine();
                Console.WriteLine();
                Console.Write("High: ");
                string hi = Console.ReadLine();
                Console.Clear();
                int loi = Convert.ToInt32(lo);
                int hii = Convert.ToInt32(hi);
                if (loi >= hii)
                {
                    Console.WriteLine("The low value cannot be higher than or equal to the high value!");
                    Console.ReadKey();
                }
                else if (hii > loi)
                {
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
                            Console.Title = "NumberGame - Lower!";
                            Console.WriteLine("Lower!");
                            guesscount++;
                        }
                        else if (guessint < ran)
                        {
                            Console.Title = "NumberGame - Higher!";
                            Console.WriteLine("Higher!");
                            guesscount++;
                        }
                    } while (guessint != ran);
                    Console.Title = "NumberGame";
                    Console.WriteLine("It took you " + guesscount + " guesses!");
                    Console.ReadKey();
                }
            } while (true);
        }
    }
}