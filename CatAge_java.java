import java.util.Scanner;

public class CatAge_java
{
    public static void main(String args[])
    {
        //Scanner
        Scanner in = new Scanner(System.in);

        //Ask the user for their cat's age
        System.out.print("Enter the age of your cat, in years: ");
        double input_age = in.nextDouble();

        //Display to converted age to the screen
        System.out.println("Your cat is " + ageConvert(input_age) + " years old.");
        
        in.close();
    }
    
    /**
     * 
     * @param in_age
     * @return
     */
    public static double ageConvert(double in_age)
    {
        if((in_age >= 0.0) && (in_age <= 1.0))
            return (16.6364 * in_age);
        else if((in_age > 1.0) && (in_age < 2.0))
            return (6.6364 * in_age + 10);
        else if(in_age >= 2.0)
            return (4.1364 * (in_age + 3.62634));
        else
            return 0;
    }
}