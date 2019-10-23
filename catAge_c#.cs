using System;

namespace catAgeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double in_age;
            double out_age;

            Console.Write("Enter your cat's age, in years: ");
            in_age = Double.Parse(Console.ReadLine());
            Console.WriteLine(in_age);

            if(in_age >= 0.0 && in_age <= 1.0)
            {
                out_age = 16.6364 * in_age;
                Console.WriteLine($"Your cat is {out_age} years old.");
            }
            else if(in_age > 1.0 && in_age < 2.0)
            {
                out_age = 6.6364 * in_age + 10;
                Console.WriteLine($"Your cat is {out_age} years old.");
            }
            else if(in_age >= 2.0)
            {
                out_age = 4.1364 * (in_age + 3.62634);
                Console.WriteLine($"Your cat is {out_age} years old.");
            }

            Console.ReadKey();
        }
    }
}