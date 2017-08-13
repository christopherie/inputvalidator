A library for validating common inputs with Regular Expressions in .NET.
RegularValidator folder contains the library. Please add your methods here.
RegularValidator.Tests consists of MSUnit Unit Tests. Please test your code beforehand.

Static regular expression methods are recommended as an alternative to repeatedly
instantiating a regular expression object with the same regular expression.

How to use in your project:
1. Include InputValidator.cs
2. Usage
			
using static System.Console;
using RegularValidator;

namespace RunValidations
{
    class Harness
    {
        public static void Main (string[] args)
        {
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

Note: I use features introduced in C# 6, like using static directives.