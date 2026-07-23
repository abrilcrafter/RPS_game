using System;
using System.Collections.Generic;
using System.Text;

namespace RPS_game
{
    internal class GameDisplay
    {
        public static void Gameplay(int userChoiceNumber, string userName)
        {

       
            Random random = new Random();
            string filePath = @"C:\Users\abril\source\repos\RPS_game\scoreboard.json";
            string computerName = System.Environment.MachineName;

            ScoreData computer = new ScoreData(computerName);
            ScoreData player = new ScoreData(userName);

            // ScoreData scoreSavedData = JsonHelper.loadScores(filePath);



            string userChoiceString = GameMovesNames.GameMovements(userChoiceNumber);

            Console.WriteLine(player.userName + " hits: " + userChoiceString + "\n");

            Console.WriteLine("Now its the program's choice!\n");

            int p_Choice = random.Next(1, 4);

            string p_ChoiceString = GameMovesNames.GameMovements(p_Choice);


            Console.WriteLine(computer.userName + " hits: " + p_ChoiceString + "\n");


            Console.WriteLine(p_ChoiceString + " vs " + userChoiceString);

            if (userChoiceNumber == p_Choice)
            {
                Console.WriteLine("Draw! Continuing..");
                Console.WriteLine("No points awarded");
            }

            else if (userChoiceNumber == 1 && p_Choice == 3 || userChoiceNumber == 2 && p_Choice == 1 || userChoiceNumber == 3 && p_Choice == 2)
            {
                player.AddPoint(1);
                Console.WriteLine("You win!");

     

               Console.WriteLine("Your current win count: " + player.points);
            

            }
            else
            {
                computer.AddPoint(1);
                Console.WriteLine("The program wins!");
               
               Console.WriteLine("Program's current win count: " + computer.points);
               

            }


   // JsonHelper.saveScores(filePath, scoreData.humanScore);
           //  JsonHelper.saveScores(filePath, scoreData.computerScore);
           
        }
       

    }
}
