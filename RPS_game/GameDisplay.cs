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
            }
            else
            {
                Console.WriteLine("The program wins!");
            }
               
        }
    }
}
