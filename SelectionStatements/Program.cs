using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 10);
            int num = 0;
            
            
            
            Console.WriteLine("Welcome to the guessing game! Please pick a number between 1 - 10:");
            num = int.Parse(Console.ReadLine());


            // how do i make the num variable declared in the while loop global (scope) available for the rest of the program 
            //order sequence of if statements is important, because once a condition is met the program will exit the loop
            //thats why the first condition we check for is if the userInput is out of range, because the later else if's would satisfy that
            //condition because it is lower or higher than the random number
            if (num < 1 || num > 10)
            {
                Console.WriteLine("Number out of range");
            }
            else if (num < favNumber)
            {
                Console.WriteLine($"{num} is too low");
            }
            else if (num > favNumber)
            {
                Console.WriteLine($"{num} is too high");
            }
            else
            {
                Console.WriteLine("Congratulations, you guessed the right number!");
            }
     

        }


        //create a while loop that keeps on asking the player for his input until he gets it right
    //    bool repeat = false;
    //        do
    //        {
    //            Console.WriteLine("What is the radius of your circle?");
    //            repeat = double.TryParse(Console.ReadLine(), out radius);
    //} while (!repeat);

    }
}
