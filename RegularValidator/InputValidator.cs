using System.Text.RegularExpressions;

namespace RegularValidator
{
	public static class InputValidator
	{
        /*
         * Static regular expression methods are recommended as an alternative to repeatedly
         * instantiating a regular expression object with the same regular expression.
         */


		// AMERICAN EXPRESS
		/// <summary>
		/// Determines if is valid american express card the specified number.
		/// </summary>
		public static bool IsValidAmericanExpressCard(string number)
		{
			const string regexPattern = @"^3[47][0-9]{13}$";
            return Regex.IsMatch(number, regexPattern);
		}

		// SIMPLE DATE 1
		/// <summary>
		/// Determines if date is valid. Matches dd-mm-yyyy.
		/// </summary>
		public static bool IsValidDateDMY(string date)
		{
			const string regexPattern = @"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$";
            return Regex.IsMatch(date, regexPattern);
        }

        // SIMPLE DATE 2
        /// <summary>
        /// Determines if date is valid. Matches yyyy-mm-dd.
        /// </summary>
        public static bool IsValidDateYMD(string date)
        {
            const string regexPattern = @"^(19|20)\d\d[- /.](0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])$";
            return Regex.IsMatch(date, regexPattern);
        }

        // DINERS CLUB
        /// <summary>
        /// Determines if Diners Club Card number is valid.
        /// </summary>
        public static bool IsValidDinersClubCard(string number)
        {
            const string regexPattern = @"^3(?:0[0-5]|[68][0-9])[0-9]{11}$";
            return Regex.IsMatch(number, regexPattern);
        }

        // DISCOVER CARD
        /// <summary>
        /// Determines if Discover Card number is valid.
        /// </summary>
        public static bool IsValidDiscoverCard(string number)
        {
            const string regexPattern = @"^6(?:011|5[0-9]{2})[0-9]{12}$";
            return Regex.IsMatch(number, regexPattern);
        }

        // EMAIL
        /// <summary>
        /// Determines if email is valid. Extension is not validated for existence.
        /// </summary>
        public static bool IsValidEmail(string email)
        {
            const string regexPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(email, regexPattern);
        }

        // Irish landline
        /// <summary>
        /// Determines if phone number is a valid Irish landline number.
        /// 00-0000000
        /// </summary>
        public static bool IsValidIrishLandline(string number)
        {
            const string regexPattern = @"^\d{2}-\d{7}$";
            return Regex.IsMatch(number, regexPattern);
        }

        // SIMPLE IRISH MOBILE NUMBER
        /// <summary>
        /// Validates mobile number. Matches 0873545656.
        /// </summary>
        public static bool IsValidIrishMobilePhone(string number)
        {
            const string regexPattern = @"^(\d{10})$";
            return Regex.IsMatch(number, regexPattern);
        }

        // MASTERCARD
        /// <summary>
		/// Determines if Mastercard number is valid.
		/// </summary>
		public static bool IsValidMasterCard(string number)
        {
            const string regexPattern = @"^(?:5[1-5][0-9]{2}|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[01][0-9]|2720)[0-9]{12}$";
            return Regex.IsMatch(number, regexPattern);
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
            return Regex.IsMatch(id, regexPattern);
        }

        // PASSWORD
        /// <summary>
        /// Determines if password is valid. 8 to 15 characters. Minumum 1 digit, lowercase, uppercase, special character. Spaces allowed.
        /// </summary>
        public static bool IsValidPassword(string password)
		{
			const string regexPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$";
            return Regex.IsMatch(password, regexPattern);
        }

        // PERSONAL PUBLIC SERVICE NUMBER
        /// <summary>
        /// Validates Personal Public Service Number (Republic of Ireland). Format is 1234567TG.
        /// </summary>
        public static bool IsValidPPSN(string id)
        {
            const string regexPattern = @"^(\d{7})([A-Z]{1,2})$";
            return Regex.IsMatch(id, regexPattern);
        }

        // SOCIAL SECURITY NUMBER
        /// <summary>
        /// Validates Social Security Numbers (United States). Format is 123-12-1234.
        public static bool IsValidSSN(string id)
        {
            const string regexPattern = @"^\d{3}-\d{2}-\d{4}$";
            return Regex.IsMatch(id, regexPattern);
        }

        // VISA CARD
        /// <summary>
        /// Determines if Visa Card number is valid.
        /// </summary>
        public static bool IsValidVisaCard(string number)
        {
            const string regexPattern = @"^4[0-9]{12}(?:[0-9]{3})?$";
            return Regex.IsMatch(number, regexPattern);
        }
    }
}

