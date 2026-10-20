using System.Text.RegularExpressions;

namespace LabWork10
{
    public class PasswordValidator
    {
        public static bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password)) 
            return false;

            bool MinimumLength = password.Length >= 8;
            bool hasDigit = password.Any(char.IsDigit);
            bool hasLatinLatter = Regex.IsMatch(password, "[a-zA-Z]");

            return hasDigit && hasLatinLatter && MinimumLength;
        }
    }
}
