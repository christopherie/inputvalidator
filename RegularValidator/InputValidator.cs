using System;
using System.Text.RegularExpressions;

namespace RegularValidator
{
	public static class InputValidator
	{
		// SOCIAL SECURITY NUMBER
		/// <summary>
		/// Validates Social Security Numbers (United States). Format is 123-12-1234.
		public static bool IsValidSSN(string id)
		{
			const string regexPattern = @"^\d{3}-\d{2}-\d{4}$";
			Match matches = Regex.Match (id, regexPattern);
			if (matches.Success) {
				return true;
			} else {
				throw new FormatException ("Invalid SSN.");
			}
		}
			
		// PERSONAL PUBLIC SERVICE NUMBER
		/// <summary>
		/// Validates Personal Public Service Number (Republic of Ireland). Format is 1234567TG.
		/// </summary>
		public static bool IsValidPPSN(string id)
		{
			const string regexPattern = @"^(\d{7})([A-Z]{1,2})$";
			Match matches = Regex.Match (id, regexPattern);
			if (matches.Success) {
				return true;
			} else {
				throw new FormatException ("Invalid PPSN.");
			}
		}

		// NATIONAL INSURANCE NUMBER
		/// <summary>
		/// Validates NI. Must be 9 characters. First 2 characters must be alpha. Next 6 characters must be numeric.
		/// Final character can be A, B, C, D or space. First character must not be D,F,I,Q,U or V.
		/// First character must not be D,F,I,Q,U or V. First 2 characters must not be combinations of GB, NK, TN 
		/// or ZZ (the term combinations covers both GB and BG etc.).
		/// </summary>
		public static bool IsValidNI(string id)
		{
			const string regexPattern = @"^(?!BG)(?!GB)(?!NK)(?!KN)(?!TN)(?!NT)(?!ZZ)(?:[A-CEGHJ-PR-TW-Z][A-CEGHJ-NPR-TW-Z])(?:\s*\d\s*){6}([A-D]|\s)$";
			Match matches = Regex.Match (id, regexPattern);
			if (matches.Success) {
				return true;
			} else {
				throw new FormatException ("Invalid NI.");
			}
		}

		// SIMPLE MOBILE NUMBER
		/// <summary>
		/// Validates mobile number. Matches 0873545656.
		/// </summary>
		public static bool IsValidPhone(string number)
		{
			const string regexPattern = @"^(\d{10})$";
			Match matches = Regex.Match (number, regexPattern);
			if (matches.Success) {
				return true;
			} else {
				throw new FormatException ("Invalid telephone.");
			}
		}

		// EMAIL
		/// <summary>
		/// Determines if email is valid. Extension is not validated for existence.
		/// </summary>
		public static bool IsValidEmail(string email)
		{
			const string regexPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
			Match matches = Regex.Match(email,regexPattern);
			if (matches.Success) {
				return true;
			} else {
				throw new FormatException ("Invalid email.");
			}
		}


		// VISA
		/// <summary>
		/// Determines if Visa Card number is valid.
		/// </summary>
		public static bool IsValidVisaCard(string number)
		{
			const string regexPattern = @"^4[0-9]{12}(?:[0-9]{3})?$";
			Match matches = Regex.Match (number, regexPattern);
			if (matches.Success) {
				return true;
			} else {
				throw new FormatException ("Invalid Visa Card Number.");
			}
		}

		/// <summary>
		/// Determines if Mastercard number is valid.
		/// </summary>
		public static bool IsValidMasterCard(string number)
		{
			const string regexPattern = @"^(?:5[1-5][0-9]{2}|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[01][0-9]|2720)[0-9]{12}$";
			Match matches = Regex.Match (number, regexPattern);
			if (matches.Success) {
				return true;
			} else {
				throw new FormatException ("Invalid Mastercard Number.");
			}
		}

		// AMERICAN EXPRESS
		/// <summary>
		/// Determines if is valid american express card the specified number.
		/// </summary>
		public static bool IsValidAmericanExpressCard(string number)
		{
			const string regexPattern = @"^3[47][0-9]{13}$";
			Match matches = Regex.Match (number, regexPattern);
			if (matches.Success) {
				return true;
			} else {
				throw new FormatException ("Invalid American Express Card Number.");
			}
		}

		// DINERS CLUB
		/// <summary>
		/// Determines if Diners Club Card number is valid.
		/// </summary>
		public static bool IsValidDinersClubCard(string number)
		{
			const string regexPattern = @"^3(?:0[0-5]|[68][0-9])[0-9]{11}$";
			Match matches = Regex.Match (number, regexPattern);
			if (matches.Success) {
				return true;
			} else {
				throw new FormatException ("Invalid Diners Club Card Number.");
			}
		}

		// DISCOVER CARD
		/// <summary>
		/// Determines if Discover Card number is valid.
		/// </summary>
		public static bool IsValidDiscoverCard(string number)
		{
			const string regexPattern = @"^6(?:011|5[0-9]{2})[0-9]{12}$";
			Match matches = Regex.Match (number, regexPattern);
			if (matches.Success) {
				return true;
			} else {
				throw new FormatException ("Invalid Discover Card Number.");
			}
		}
			
		// SIMPLE DATE 1
		/// <summary>
		/// Determines if date is valid. Matches yyyy-mm-dd.
		/// </summary>
		public static bool IsValidDateYMD(string date)
		{
			const string regexPattern = @"^(19|20)\d\d[- /.](0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])$";
			Match matches = Regex.Match (date, regexPattern);
			if (matches.Success) {
				return true;
			} else {
				throw new FormatException ("Invalid Date Format.");
			}
		}

		// SIMPLE DATE 2
		/// <summary>
		/// Determines if date is valid. Matches dd-mm-yyyy.
		/// </summary>
		public static bool IsValidDateDMY(string date)
		{
			const string regexPattern = @"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$";
			Match matches = Regex.Match (date, regexPattern);
			if (matches.Success) {
				return true;
			} else {
				throw new FormatException ("Invalid Date Format.");
			}
		}
			
		// PASSWORD
		/// <summary>
		/// Determines if password is valid. 8 to 15 characters. Minumum 1 digit, lowercase, uppercase, special character. Spaces allowed.
		/// </summary>
		public static bool IsValidPassword(string password)
		{
			const string regexPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$";
			Match matches = Regex.Match (password, regexPattern);
			if (matches.Success) {
				return true;
			} else {
				throw new FormatException ("Weak password.");
			}
		}
	}
}

