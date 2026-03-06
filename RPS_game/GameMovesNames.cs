using System;
using System.Collections.Generic;
using System.Text;

public enum handMovements
{
    ROCK = 1,
    PAPER = 2,
    SCISSORS = 3
}
namespace RPS_game
{
    internal class GameMovesNames
    {
        public static String GameMovements(int gameMovements)
        {
            handMovements myHandMovement = handMovements.ROCK;
            string gameMovementString = gameMovements.ToString();

            if (gameMovements == (int)handMovements.ROCK)
            {
                myHandMovement = (handMovements)1;
            }
            else if (gameMovements == (int)handMovements.PAPER)
            {
                myHandMovement = (handMovements)2;
            }
            else if (gameMovements == (int)handMovements.SCISSORS)
            {
                myHandMovement = (handMovements)3;

            }

           string handmovement= myHandMovement.ToString();
            
           return handmovement;
        }

    }
}
