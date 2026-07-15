using System;
using System.Collections.Generic;
using System.Text;

namespace RPS_game
{
    internal class GameDisplay
    {
        public static void Gameplay(int userChoiceNumber)
        {

            Random random = new Random();
            string filePath = @"C:\Users\abril\source\repos\RPS_game\scoreboard.json";
            // ScoreData scoreSavedData = JsonHelper.loadScores(filePath);
            int winCount = 0;
            int loseCount = 0;




            string userChoiceString = GameMovesNames.GameMovements(userChoiceNumber);

            Console.WriteLine("You hit: " + userChoiceString + "\n");

            Console.WriteLine("Now its the program's choice!\n");



            int p_Choice = random.Next(1, 4);

            string p_ChoiceString = GameMovesNames.GameMovements(p_Choice);


            Console.WriteLine("The program hits: " + p_ChoiceString + "\n");


            Console.WriteLine(p_ChoiceString + " vs " + userChoiceString);

            if (userChoiceNumber == p_Choice)
            {
                Console.WriteLine("Draw! Continuing..");
            }

            else if (userChoiceNumber == 1 && p_Choice == 3 || userChoiceNumber == 2 && p_Choice == 1 || userChoiceNumber == 3 && p_Choice == 2)
            {

                Console.WriteLine("You win!");
                ++winCount;
                //string filePath = @"C:\Users\abril\source\repos\RPS_game";
                //JsonHelper.saveScores(filePath, winCount);

            }
            else
            {
                Console.WriteLine("The program wins!");
                ++loseCount;
                // string filePath = @"C:\Users\abril\source\repos\RPS_game";





            }
            
            JsonHelper.saveScores(filePath, loseCount);
            Console.WriteLine("Your current win count: " + winCount);
            Console.WriteLine("Program's current win count: " + loseCount);

            

            //winCount = JsonHelper.loadScores(filePath).humanScore;
            //loseCount = JsonHelper.loadScores(filePath).computerScore;
            // FileHandling.addWins();
        }

    }
}
