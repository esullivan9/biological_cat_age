using System;

namespace catAgeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double inAge;

            Console.Write("Enter your cat's age, in years: ");

            try
            {
                inAge = Double.Parse(Console.ReadLine());
                
                if (inAge >= 0)
                    ConvertAge(inAge);
                else
                    Console.WriteLine("Error.");

                Console.ReadKey();
            }
            catch(FormatException)
            {
                Console.WriteLine("Numbers only!");
                Console.ReadKey();
            }
        }

        private static void ConvertAge(double inAge)
        {
            double tmpAge, outAge;
            if (inAge >= 0.0 && inAge <= 1.0)
            {
                tmpAge = 16.6364 * inAge;
                outAge = Round(tmpAge);
                Console.WriteLine($"Your cat is {outAge} years old.");
            }
            else if (inAge > 1.0 && inAge < 2.0)
            {
                tmpAge = 6.6364 * inAge + 10;
                outAge = Round(tmpAge);
                Console.WriteLine($"Your cat is {outAge} years old.");
            }
            else if (inAge >= 2.0)
            {
                tmpAge = 4.1364 * (inAge + 3.62634);
                outAge = Round(tmpAge);
                Console.WriteLine($"Your cat is {outAge} years old.");
            }
        }

        private static double Round(double inAge)
        {
            return Math.Round(inAge * 10000.0) / 10000.0;
        }
    }
}