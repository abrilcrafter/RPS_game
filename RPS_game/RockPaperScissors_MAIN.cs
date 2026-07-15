using System;

namespace RPS_game
{
    class RockPaperScissors_MAIN
    {
        static void Main(string[] args)
        {

            String userChoice;
            String quitOrContinue = "y";
          

            // FileHandling.FileCreation();

            Console.WriteLine("Rock Paper Scissors!");
            Console.WriteLine("Press any key to start...");

            Console.ReadKey(true);


            Console.WriteLine();


            while (quitOrContinue == "y")
            {

                bool validNumRange = false;
                int userChoiceNum = 0;

                while (!validNumRange)
                {
                    userChoice = InputValidator.CheckNumbers("1 = ROCK\n2 = PAPER\n3 = SCISSORS\n \n\"Rock Paper Scissors!\": ");
                Console.WriteLine();

                    userChoiceNum = Convert.ToInt32(userChoice);
                    InputValidator.CheckNumberRange(userChoiceNum);


                    validNumRange = InputValidator.CheckNumberRange(userChoiceNum);

                    if (!validNumRange)
                    {
                        Console.WriteLine("Your input must be between 1 and 3. Try again.");
                    }
                        
                }
                GameDisplay.Gameplay(userChoiceNum);
                quitOrContinue = InputValidator.CheckStrings("Continue game? (y/n)");
                //FileHandling.FileCreation();
            }
            Console.WriteLine("Bye Thank you for playing!\n");
        }
    }
}
