import java.util.Scanner;

public class CatAge_java
{
    public static void main(String args[])
    {
        //Scanner.
        Scanner in = new Scanner(System.in);

        //Ask the user for their cat's age.
        System.out.print("Enter the age of your cat, in years: ");
        double inputAge = in.nextDouble();

        //Display to converted age to the screen.
        System.out.println("Your cat is " + ageConvert(inputAge) + " years old.");
        
        //Close the scanner.
        in.close();
    }
    
    /**
     * Calculates the "actual" age of a cat based on the age 
     * entered by the user.
     * @param inputAge The age the user has entered for their cat.
     * @return The "actual" age of the cat.
     */
    public static double ageConvert(double inputAge)
    {
        if((inputAge >= 0.0) && (inputAge <= 1.0))
            return (16.6364 * inputAge);
        else if((inputAge > 1.0) && (inputAge < 2.0))
            return (6.6364 * inputAge + 10);
        else if(inputAge >= 2.0)
            return (4.1364 * (inputAge + 3.62634));
        else
            return 0;
    }
}