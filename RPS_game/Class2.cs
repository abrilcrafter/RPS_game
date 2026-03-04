using System;
using System.Collections.Generic;
using System.Text;
//public enum handMovements
//{
//    ROCK=1,
//    PAPER=2,
//    SCISSORS=3
//}
namespace RPS_game
{
    internal class Class2
    {
        public static void Gameplay(int userChoiceNumber)
        {

            Random random = new Random();


            //assigning names to the hand movements from the enum constants
            //handMovements myHandMovement = handMovements.ROCK;

            //if (userChoiceNumber == (int)handMovements.ROCK)
            //{
            //    myHandMovement = (handMovements)1;
            //}
            //else if (userChoiceNumber == (int)handMovements.PAPER)
            //{
            //    myHandMovement = (handMovements)2;
            //}
            //else if (userChoiceNumber == (int)handMovements.SCISSORS)
            //{
            //    myHandMovement = (handMovements)3;

            //}


            string userChoiceString = Class3.GameMovements(userChoiceNumber);

         //   Class3.GameMovements(userChoiceNumber);
            
            Console.WriteLine("Now its the program's choice!");
            
            int p_Choice = random.Next(1, 4);

            string p_ChoiceString = Class3.GameMovements(p_Choice);
            

            Console.WriteLine(p_ChoiceString + " vs " + userChoiceString);

            if (userChoiceNumber == p_Choice)
            {
                Console.WriteLine("Draw! Continuing..");
            }

            else if (userChoiceNumber == 1 && p_Choice == 3 || userChoiceNumber == 2 && p_Choice == 1 || userChoiceNumber == 3 && p_Choice == 2) //rock beats scissors
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
