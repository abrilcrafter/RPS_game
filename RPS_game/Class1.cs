using System;
using System.Collections.Generic;
using System.Text;

namespace RPS_game
{
    internal class Class1
    {
        public static String CheckNumbers(string prompt)
        {
            while (true)
            {
               
                Console.Write("\n" + prompt);
                String numberChoice = Console.ReadLine();
                try
                {
                    if (!string.IsNullOrEmpty(numberChoice))
                    { 
                        
                        return numberChoice;
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


    }
}
