using System;
using System.Text.RegularExpressions;
using System.Text;

namespace BankingApp_ARO.ViewModels
{
    public sealed class SSNValidationVM
    {

        public SSNValidationVM()
        {

        }

        public static bool ValidateSSN(string ssNumber)
        {
            string regEx = "[0-9]{13}";
            bool isMatch = Regex.IsMatch(ssNumber, regEx);
            
            
            var month = Int64.Parse(ssNumber.Substring(2, 2));
            var date = Int64.Parse(ssNumber.Substring(4, 2));

            var y = ssNumber.Substring(0, 2);
            var currentYear = DateTime.Today.Year;
            var year = Int64.Parse(currentYear.ToString().Substring(0, 2) + y); // year in 4 digit to be passed in date time initializer

            if (year > currentYear)
            {
                year = year - 100; // - 100 years for vlid years
            }

            //check for valid birthdate
            DateTime birthDate = new DateTime();
            try
            {
                birthDate = new DateTime((int)year, (int)month, (int)date);
            }
            catch
            {
                isMatch = false;
                goto Match;
            }

            //check for gender should be less than 1000
            var gender = Int64.Parse(ssNumber.Substring(6, 4));
            if (gender > 10000)
            {
                isMatch = false;
                goto Match;
            }

            //should be 0 or 1
            var isPermanent = Int64.Parse(ssNumber.Substring(10, 1));
            if (isPermanent > 1)
            {
                isMatch = false;
                goto Match;
            }


            Match:
            return isMatch;
        }
    }
}
