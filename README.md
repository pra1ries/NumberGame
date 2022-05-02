# NumberGame
A small game written in C#

# How it works
First, the program declares a Random, we'll use this later.

`Random rn = new Random();`

The program prompts the user for the highest and lowest number that will be generated.

These

`Console.WriteLine("Please set your number parameters.");

 Console.Write("Low: ");
 
 string lo = Console.ReadLine();
 
 Console.WriteLine();
 
 Console.Write("High: ");
 
 string hi = Console.ReadLine();`
 
 Currently the user input is stored as a `string`, so the program converts it to an `int`.
 
 These variables are called `loi` and `hii`.
 
 `int loi = Convert.ToInt32(lo);
 
 int hii = Convert.ToInt32(hi);`
