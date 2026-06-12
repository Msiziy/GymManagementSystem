using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Gym_Management_System
{
    public static class ValidationHelper
    {
       

        public static bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^[A-Za-z\s\-]+$");
        }

        public static bool IsNotEmpty(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        public static string Trim(string value)
        {
            return value?.Trim();
        }

        public static bool IsValidStaffID(string staffID)
        {
            return staffID.Length == 6 && staffID.All(char.IsDigit);
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        public static bool IsValidPhone(string number)
        {
            return number.Length == 10 &&
                   number.StartsWith("0") &&
                   number.All(char.IsDigit);
        }


        public static int CalculateAge(DateTime dob)
        {
            int age = DateTime.Now.Year - dob.Year;

            if (dob.Date > DateTime.Now.AddYears(-age))
                age--;

            return age;
        }

        public static bool IsValidAge(DateTime dob, int minAge)
        {
            return CalculateAge(dob) >= minAge;
        }

        public static bool IsFutureDate(DateTime date)
        {
            return date.Date >= DateTime.Now.Date;
        }

        public static bool IsComboSelected(int selectedIndex)
        {
            return selectedIndex != -1;
        }

        public static bool AreRequiredFieldsFilled(params string[] fields)
        {
            return fields.All(f => !string.IsNullOrWhiteSpace(f));
        }
        public static bool IsDigitsOnly(string value)
        {
            return value.All(char.IsDigit);
        }

        public static bool IsValidMemberID(string memberID)
        {
            return memberID.Length == 9 &&
                   memberID.All(char.IsDigit);
        }

        public static bool IsValidPostalCode(string postalCode)
        {
            return postalCode.Length == 4 &&
                   postalCode.All(char.IsDigit);
        }

        public static bool IsAlphabetOnly(string value)
        {
            return value.All(c => char.IsLetter(c) || c == ' ');
        }

        public static bool IsValidStreetNumber(string value)
        {
            return int.TryParse(value, out _);
        }

        public static bool ContainsNoSpaces(string value)
        {
            return !value.Contains(" ");
        }

        public static bool IsValidTelephone(string number)
        {
            return string.IsNullOrWhiteSpace(number) ||
                   IsValidPhone(number);
        }
    }
}
