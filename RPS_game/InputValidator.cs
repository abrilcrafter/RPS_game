using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace RPS_game
{
    internal class InputValidator
    {
        public static String CheckNumbers(string prompt)
        {
            while (true)
            {
                Console.Write("\n" + prompt);

                string numberChoice = Console.ReadLine();
                try
                {
                    if (int.TryParse(numberChoice, out int number))
                    {
                         if (!string.IsNullOrEmpty(numberChoice))
                        {

                            return numberChoice;
                        }
                    }
                     else
                    {
                        throw new ArgumentNullException("This input cannot be empty!");
                    } 
                   
                        
                }
                catch (ArgumentNullException e)
                {
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }  
        //public static int CheckValidInt(int userChoiceNum)
        //{
        //    while (true)
        //    {
        //        try
        //        {

        //        }
        //        catch()
        //        {

        //        }
        //    }
        //}
        public static bool CheckNumberRange(int userChoiceNum)
        {

            if (userChoiceNum <= 0 || userChoiceNum > 3)
            { 
                return false;
            }
            return true;
       
        }
 
        public static String CheckStrings(String prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string choice = Console.ReadLine().Trim();


                if (string.Equals(choice, "y", StringComparison.OrdinalIgnoreCase) || string.Equals(choice, "n", StringComparison.OrdinalIgnoreCase))
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Please enter (y/n): ");
                }

            }
        }


    }
}
