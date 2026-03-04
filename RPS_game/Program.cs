using System;

namespace RPS_game
{
    class Program
    {
        static void Main(string[] args)
        {
            String userChoice;
            Random random = new Random();
            int randomNumberGenerator = random.Next(1, 3);

            

            Console.WriteLine("Rock Paper Scissors!");
            Console.WriteLine("Press any key to start...");

            Console.ReadKey(true);

           
            Console.WriteLine();

            userChoice = Class1.CheckNumbers("1 = ROCK\n2 = PAPER\n3 = SCISSORS\n \" Rock Paper Scissors! \":  ");
            int userChoiceNum = Convert.ToInt32(userChoice);

            Class2.Gameplay(userChoiceNum);

            Console.WriteLine("Bye");
          //validate user input to be an integer between 1-3


        }
    }
}
