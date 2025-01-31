using System; // Importing the System namespace to use Console methods

public class Shipping_Quote // Defining a public class named Shipping_Quote
{
    public static void Main(string[] args) // Entry point of the program
    {
        // Displaying a welcome message to the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
        
        // Prompting the user to enter the weight of the package
        Console.Write("Please enter the weight of the package: ");
        double weight = Convert.ToDouble(Console.ReadLine()); // Reading and converting user input to double
        
        // Checking if the package weight is within the allowed limit
        if(weight <= 50)
        {
            // Prompting the user to enter the package dimensions
            Console.Write("Please enter the width of the package: ");
            double width = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Please enter the height of the package: ");
            double height = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Please enter the length of the package: ");
            double length = Convert.ToDouble(Console.ReadLine());
            
            // Checking if the dimensions total is within the allowed limit
            if((height + length + width) <= 50)
            {
                // Calculating the shipping quote
                double quote = (length * width * height * weight) / 100.0;
                
                // Displaying the calculated shipping cost formatted to 2 decimal places
                Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            }
            else // If the package dimensions exceed the allowed limit
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
        }
        else // If the package weight exceeds the allowed limit
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        }
    }
}