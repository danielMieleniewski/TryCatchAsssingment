using System;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their age
            Console.WriteLine("Please enter your age:");

            try
            {
                // Parse the user's input to an integer
                int age = int.Parse(Console.ReadLine());

                // Check if the age is zero or negative, which is not valid
                if (age <= 0)
                {
                    // If age is zero or negative, display an error message
                    Console.WriteLine("Error: Age must be a positive number.");
                }
                else
                {
                    // Calculate the birth year based on the current year
                    int birthYear = DateTime.Now.Year - age;

                    // Display the calculated birth year to the user
                    Console.WriteLine("You were born in the year: " + birthYear);
                }
            }
            catch (FormatException)
            {
                // Handle the case where input is not a valid integer
                Console.WriteLine("Error: Please enter a valid number for your age.");
            }
            catch (Exception ex)
            {
                // Handle any other unexpected exceptions
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            // Wait for the user to press Enter before closing the console
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
