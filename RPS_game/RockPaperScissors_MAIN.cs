using System;

namespace RPS_game
{
    class RockPaperScissors_MAIN
    {  
        [STAThread]
        static void Main(string[] args)
        {
           
      
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new RPS_Form());

            String userChoice;
            String quitOrContinue = "y";
            String? username = null;
            string computerName = System.Environment.MachineName;




          //  Console.WriteLine("----Rock Paper Scissors!----\n");

          //  Console.Write("ENTER A USERNAME, HUMAN: ");
            username = Console.ReadLine();

         

       //     Console.WriteLine("\nPress any key to start...");

                ScoreData computer = new ScoreData(computerName);
                ScoreData player = new ScoreData(username);

          //  Console.ReadKey(true);


         //   Console.WriteLine();


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
                quitOrContinue = InputValidator.CheckStrings("\nContinue game? (y/n)");
                //FileHandling.FileCreation();
            }
            Console.WriteLine("\n\nBye Thank you for playing!\n");

            //Console.WriteLine("Human overall score: " +  );
            //Console.WriteLine("Computer overall score: " + );
        }
  

    }
}
