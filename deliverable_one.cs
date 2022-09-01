using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bread_per_san = 2;
            int pb_per_san = 2;
            int jelly_per_san = 4;

            int loaf = 14; //servings
            int jarP = 16; //servings
            int jarJ = 12; //servings



            do
            {


                Console.WriteLine("How many people are we making PB and J sandwiches for?");

                int people = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(people * bread_per_san + " slices of bread");
                Console.WriteLine(people * pb_per_san + " tablespoons of peanut butter");
                Console.WriteLine(people * jelly_per_san + " teaspoons of jelly");
                Console.WriteLine("");
                Console.WriteLine("which is");
                Console.WriteLine("");
                Console.WriteLine(people / loaf + " loaves of bread");
                Console.WriteLine(people / jarP + " jars of peanut butter");
                Console.WriteLine(people / jarJ + " jars of jelly");
                Console.WriteLine("");
                
                Console.WriteLine("Would you like to restart? Enter yes or y to continue or enter any other key to exit");
                string answer = Console.ReadLine();
                
                if (answer == "yes")
                {
                    continue;
                }

                else if (answer == "y")
                {
                    continue;
                }
                
                else
                {
                    Console.WriteLine("Goodbye");
                    break;
                }

            }
            while (true);


        }
    }
}
