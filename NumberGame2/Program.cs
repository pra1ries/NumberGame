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
                int loi = Convert.ToInt32(lo); // converts lo string to int
                int hii = Convert.ToInt32(hi); // converts hi string to int
                if (loi >= hii) // checks to make sure low value is not higher than the high value
                {
                    Console.WriteLine("The low value cannot be higher than or equal to the high value!"); // if low value is higher than the high value, return this message.
                    Console.ReadKey(); // wait for a key to be pressed, then close application
                }
                else if (hii > loi)
                {
                    int ran = rn.Next(loi, hii); // generates random number according to the parameters set earlier
                    int guessint;
                    Console.WriteLine("Guess a number!");
                    int guesscount = 1; 
                    do
                    {
                        Console.Write("Guess: ");
                        string guess = Console.ReadLine(); // saves guess
                        guessint = Convert.ToInt32(guess); // converts guess to integer
                        Console.Clear();
                        if (guessint == ran) // checks to see if answer is correct
                        {
                            Console.WriteLine("Correct!");
                            break;
                        }
                        else if (guessint > ran) // checks to see if guess is higher than answer
                        {
                            Console.Title = "NumberGame - Lower!";
                            Console.WriteLine("Lower!");
                            guesscount++; // adds 1 guess to guesscount
                        }
                        else if (guessint < ran) // checks to see if guess is lower than answer
                        {
                            Console.Title = "NumberGame - Higher!";
                            Console.WriteLine("Higher!");
                            guesscount++; // adds 1 guess to guesscount
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