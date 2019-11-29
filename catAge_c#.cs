using System;

namespace catAgeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double inAge;

            //Prompts the user to enter the age they say their cat is.
            Console.Write("Enter your cat's age, in years: ");

            try
            {
                //Takes the user's input and converts it to a double.
                inAge = Double.Parse(Console.ReadLine());
                
                //Makes sure the user entered a valid number.
                if (inAge >= 0)
                    //Calls the method to do the conversion, then the
                    //result is displayed to the screen.
                    Console.WriteLine($"Your cat is {ConvertAge(inAge)} years old.");
                else
                    Console.WriteLine("Error.");

                //Allows the user to see the result of the function.
                Console.ReadKey();
            }
            //Makes sure that the user enters only numbers.
            catch(FormatException)
            {
                Console.WriteLine("Numbers only!");
                Console.ReadKey();
            }
        }

        //Method that calculates the "actual" age of a cat 
        //based on the age entered by the user. Displays the
        //result of the conversion to the screen.        
        private static double ConvertAge(double inAge)
        {
            double tmpAge;
            if (inAge >= 0.0 && inAge <= 1.0)
            {
                tmpAge = 16.6364 * inAge;
                return Round(tmpAge);
            }
            else if (inAge > 1.0 && inAge < 2.0)
            {
                tmpAge = 6.6364 * inAge + 10;
                return Round(tmpAge);
            }
            else if (inAge >= 2.0)
            {
                tmpAge = 4.1364 * (inAge + 3.62634);
                return Round(tmpAge);
            }
        }

        //A convenience function that rounds the result of the conversion 
        //to 4 decimal places.
        private static double Round(double inAge)
        {
            return Math.Round(inAge * 10000.0) / 10000.0;
        }
    }
}