using System;
using System.Text.RegularExpressions;

namespace UserregistrationDay10
{
    public class UserRegistrationException : Exception
    {
        public enum ExceptionType
        {
            ENTERED_EMPTY,
            MINIMUM_THREE_LETTER,
            ENTERED_NULL,
        }
        public ExceptionType exceptionType;
        public UserRegistrationException(ExceptionType exceptionType, string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
    public class Useregex
    {
        //Pattern regex for validation
        Regex firstNameregex = new Regex("^[A-Z][a-zA-Z]{2,}$");
        Regex lastNameRegex = new Regex(@"^[A-Z][a-zA-Z]{2,}$");

        public bool ValidateFirstName(string first_Name)
        {
            //Validate first name
            Func<Regex, string, bool> IsValid = (reg, field) => reg.IsMatch(field);
            try
            {
                if (first_Name.Equals(string.Empty))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_EMPTY, "first name  should not be capital");

                if (first_Name.Length < 3)
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.MINIMUM_THREE_LETTER, "first name should not be less than minimum length");
                return IsValid(firstNameregex, first_Name);

            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_NULL, "first name should not be null");
            }

        }
        public bool ValidateLastName(string last_Name)
        {
            //Validate last name
            Func<Regex, string, bool> IsValid = (reg, field) => reg.IsMatch(field);
            try
            {
                if (last_Name.Equals(string.Empty))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_EMPTY, "first name  should not be capital");

                if (last_Name.Length < 3)
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.MINIMUM_THREE_LETTER, "first name should not be less than minimum length");
                return IsValid(firstNameregex, last_Name);

            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_NULL, "first name should not be null");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome userregistration");
        }
    }
}