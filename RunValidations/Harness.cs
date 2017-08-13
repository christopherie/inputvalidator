using static System.Console;
using RegularValidator;

namespace RunValidations
{
	class Harness
	{
		public static void Main (string[] args)
		{
            // Example usage

            // Validate ssn input
            if (InputValidator.IsValidSSN("123-12-1234"))
            {
                // TODO
            }
            else
            {
                WriteLine("Invalid SSN format");
            }


            // Hold Terminal
            ReadLine();
		}
	}
}
