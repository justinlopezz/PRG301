using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rolls = 0;
            int nor = 1;
            List<int> numbers = new List<int>();

            Console.WriteLine("Hello");
            Console.WriteLine("");
            Console.WriteLine("Type in 'Roll' to Roll the Dice, type 'Stop' to Stop Rolling, Type 'End' to End the Program:");
            Console.WriteLine("");
            Console.Write("");
            

            while (rolls <= 100)
            {
                Console.WriteLine("Choose: \n-Roll\n-Stop\n-End");
                Console.WriteLine("");

                string[] choices = new string[3] { "ROLL", "STOP", "END" };
                string userInput = Console.ReadLine().ToUpper();

                Console.WriteLine("");
                if (userInput == "ROLL")
                {
                    Random dice = new Random();
                    int d = dice.Next(1, 6);

                    numbers.Add(d);

                    Console.WriteLine(nor + " Roll(s), " + "You Rolled A: " + d);
                    Console.WriteLine("");

                    nor++;
                    rolls++;
                }

                else if (userInput == "STOP")
                {
                    Console.WriteLine("How Many Rolls Would You Like To Examine: ");

                    int examine = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    if (examine != nor)
                    {
                        Console.Write("Average: " + numbers.Average() + "\n");
                        Console.Write("Total: " + numbers.Sum() + "\n");
                        Console.WriteLine("Your Roll Log: ");
                        numbers.ForEach(Console.WriteLine);
                    }
                    else if (examine < nor)
                    {
                        
                        Console.Write("Average: " + numbers.Average() + "\n");
                        Console.Write("Total: " + numbers.Sum() + "\n");
                        Console.WriteLine("Your Roll Log: ");
                        numbers.ForEach(Console.WriteLine);
                    }
                    else
                    {
                        Console.WriteLine("Select a Number, silly");
                    }
                    Console.WriteLine("");
                    Console.Write("Press Any Key To Close...");
                    break;
                }

                else if (userInput == "END")
                {
                    Console.WriteLine("Goodbye");
                    Console.WriteLine("");
                    Console.Write("Press Any Key To Close...");
                    break;
                }
                else
                {

                }
            }
            Console.ReadLine();
        }
        
    }
    
}
