using System;
using System.Linq;

namespace InputValidator
{
    public static class Input
    {
        /// <summary>
        /// Test a users input against an array of acceptable values.
        /// </summary>
        /// <param name="displayMessage"></param>
        /// <param name="acceptedValues"></param>
        /// <returns></returns>
        public static string ValidateArray(string displayMessage, string[] acceptedValues)
        {
            bool inputValid = false;
            string inputFinal = "";

            // Loop until good/valid output acchived.
            while (!inputValid)
            {
                // Print the message and then read the input, converting it to lowercase.
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(displayMessage);
                string input = Console.ReadLine().ToLower();
                Console.ResetColor();
                // Check if the entered is in the array of accepted values.
                if (acceptedValues.Contains(input))
                {
                    // If it is accepted, input is finalised and then is marked as valid.
                    inputFinal = input;
                    inputValid = true;
                }
                else
                {
                    // If not accepted, keep looping and display and error.
                    Console.WriteLine("Sorry, Your input was not valid, Please try again...");
                }
            }

            // Finally, return the input.
            return inputFinal;
        }

        /// <summary>
        /// Yes/No Input Question Handler.
        /// </summary>
        /// <param name="displayMessage"></param>
        /// <returns></returns>
        public static bool ValidateYN(string displayMessage)
        {
            // Run the Validation, accepting yes or no.
            string val = Input.ValidateArray(displayMessage, new string[] { "yes", "no", "y", "n" });

            // Take the first letter, return true for yes, return false for no.
            switch (val.Substring(1, val.Length - 1))
            {
                case "y":
                    return true;

                case "n":
                    return false;
            }

            // Unreachable, but here to suppress warnings.
            return false;
        }
    }
}
