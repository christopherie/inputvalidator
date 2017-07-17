using System;
using static System.Console;
using RegularValidator;

namespace RunValidations
{
	class Harness
	{
		public static void Main (string[] args)
		{
			// example use

			// validate email input
			try {
				WriteLine (InputValidator.IsValidEmail ("chris@gmail.com"));
			} catch (Exception ex) {
				WriteLine (ex.Message);
			}


			// validate ppsn input
			try {
				WriteLine (InputValidator.IsValidPPSN ("1234567TH"));
			} catch (Exception ex) {
				WriteLine (ex.Message);
			}

			// validate password
			try {
				WriteLine (InputValidator.IsValidPassword ("Christopher@1"));
			} catch (Exception ex) {
				WriteLine (ex.Message);
			}

            // hold
            ReadLine();
		}
	}
}
