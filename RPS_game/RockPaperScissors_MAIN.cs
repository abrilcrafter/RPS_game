using System;

namespace RPS_game
{
    class RockPaperScissors_MAIN
    {
        static void Main(string[] args)
        {
           
                String userChoice;
                String quitOrContinue = "y";
                Random random = new Random();
                int randomNumberGenerator = random.Next(1, 3);



                Console.WriteLine("Rock Paper Scissors!");
                Console.WriteLine("Press any key to start...");

                Console.ReadKey(true);


                Console.WriteLine();

            while (quitOrContinue == "y")
            {
                userChoice = InputValidator.CheckNumbers("1 = ROCK\n2 = PAPER\n3 = SCISSORS\n \n\"Rock Paper Scissors!\": ");
                Console.WriteLine();
                int userChoiceNum = Convert.ToInt32(userChoice);
               

                //bool checkResult =  InputValidator.CheckNumberRange(userChoiceNum);
                //if (!checkResult)
                //{
                //    Console.WriteLine("Input out of range");
                //    return;
                //}

                GameDisplay.Gameplay(userChoiceNum);
                quitOrContinue = InputValidator.CheckStrings("Continue game? (y/n)");

             
               
            } //while true 
   Console.WriteLine("Bye Thank you for playing!");
        }
    }
}
