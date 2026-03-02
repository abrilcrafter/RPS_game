using System;
using System.Collections.Generic;
using System.Text;
public enum handMovements
{
    ROCK=1,
    PAPER=2,
    SCISSORS=3
}
namespace RPS_game
{
    internal class Class2
    {
        public static void Gameplay(int userChoiceNumber)
        {

            Random random = new Random();

            handMovements myHandMovement = handMovements.ROCK;

            if (userChoiceNumber == (int)handMovements.ROCK)
            {
                myHandMovement = (handMovements)1;
            }
            else if (userChoiceNumber == (int)handMovements.PAPER)
            {
                myHandMovement = (handMovements)2;
            }
            else if (userChoiceNumber == (int)handMovements.SCISSORS)
            {
                myHandMovement = (handMovements)3;
           
            }
      
            
            Console.WriteLine("Now its the program's choice!");
            
            int p_Choice = random.Next(1, 3);

            Console.WriteLine(p_Choice + " vs " + myHandMovement);




        }
    }
}
