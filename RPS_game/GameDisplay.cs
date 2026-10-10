using System;
using System.Collections.Generic;
using System.Text;

namespace RPS_game
{
    internal class GameDisplay
    {
        public static async Task Gameplay(int userChoiceNumber, ScoreData player, ScoreData computer)
        {

       
            Random random = new Random();
            string filePath = @"C:\Users\abril\source\repos\RPS_game\scoreboard.json";
    
            // ScoreData scoreSavedData = JsonHelper.loadScores(filePath);

            string userChoiceString = GameMovesNames.GameMovements(userChoiceNumber);

            Console.WriteLine(player.userName + " hits: " + userChoiceString + "\n");

            Console.WriteLine("Now its the program's choice!\n");

            int p_Choice = random.Next(1, 4);

           

            string p_ChoiceString = GameMovesNames.GameMovements(p_Choice);

             Thread.Sleep(1000);

            Console.WriteLine(computer.userName + " hits: " + p_ChoiceString + "\n");

            Console.WriteLine();
            Console.WriteLine(p_ChoiceString + " vs " + userChoiceString);

            if (userChoiceNumber == p_Choice)
            {
                Console.WriteLine("\nDraw! Continuing..");
                Console.WriteLine("NO POINTS AWARDED");
            }

            else if (userChoiceNumber == 1 && p_Choice == 3 || userChoiceNumber == 2 && p_Choice == 1 || userChoiceNumber == 3 && p_Choice == 2)
            {
                player.AddPoint();
                Console.WriteLine("YOU WIN!");
                
     
               Console.WriteLine("Your current win count: " + player.totalPoints);
            

            }
            else
            {
                computer.AddPoint();
                Console.WriteLine("THE PROGRAM WINS!");

               
               Console.WriteLine("Program's current win count: " + computer.totalPoints);
               

            }


            // JsonHelper.saveScores(filePath, scoreData.humanScore);
           //  JsonHelper.saveScores(filePath, scoreData.computerScore);
           
        }
        static void displayFinalScore(int finalScore)
        {
           
        }


    }
}
