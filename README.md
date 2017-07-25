A library for validating common inputs with Regular Expressions in C#.
RegularValidator folder contains the library. Please add your methods here.
RegularValidator.Tests consists of MSUnit Unit Tests. Please test your code beforehand.

How to use in your project:
1. Include InputValidator.cs
2. // validate email input
			
try {
				
	WriteLine (InputValidator.IsValidEmail ("chris@gmail.com"));
			
} catch (Exception ex) {
				
	WriteLine (ex.Message);
			
}

Note: I use features introduced in C# 6, like using static directives.