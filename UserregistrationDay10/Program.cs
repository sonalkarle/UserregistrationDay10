using System;
using System.Linq;
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
            INVALID_MAILID,
            ENTERED_MINIMUM_LENGTH,
            ENTERED_DIGIT_IN_MAILID,
            ENTERED_INVALID_EMAIL_TLD,
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
        Regex emailAddressRegex = new Regex(@"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2,})?$");
        Regex mobileNumberRegex = new Regex(@"^[0-9]{2,3}\s[1-9][0-9]{9}$");
        Regex passwordRegex = new Regex(@"^(?=.{8,20}$)(?=.*[\d])(?=.*[A-Z])[\w]*[\W][\w]*$");
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
        public bool ValidateEmailAddress(string EmailAddress)
        {
            //Validate email id
            Func<Regex, string, bool> IsValid = (reg, field) => reg.IsMatch(field);

            try
            {
                if (EmailAddress.Equals(string.Empty))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_EMPTY, "email address should not be empty");

                string Username = EmailAddress.Substring(0, 1);
                if (Username.Any(Char.IsPunctuation))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MAILID, "email address username should not start with spacial character");
                if (EmailAddress.Length < 6)
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_MINIMUM_LENGTH, "email address should not be less than minimum lengthe");
                string Country_Tld = EmailAddress.Substring(EmailAddress.LastIndexOf(".") + 1);
                if (Country_Tld.Any(Char.IsDigit))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_DIGIT_IN_MAILID, "email address country tld should not contain spacial characters");

                string tld = EmailAddress.Substring(EmailAddress.LastIndexOf("@") + 1, EmailAddress.Substring(EmailAddress.LastIndexOf("@") + 1).IndexOf("."));
                if (tld.Any(Char.IsPunctuation))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_INVALID_EMAIL_TLD, "email address tld should not be contain special characters");
                return IsValid(emailAddressRegex, EmailAddress);
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_NULL, "email address should not be null");
            }
        }
        public bool ValidateMobileNumber(string MobileNumber)
        {
            //validate mobile number
            Func<Regex, string, bool> IsValid = (reg, field) => reg.IsMatch(field);

            try
            {
                if (MobileNumber.Length.Equals(0))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_EMPTY, "mobile number should not be empty");
                if (MobileNumber.Length < 13)
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_MINIMUM_LENGTH, "email address should not be less than minimum lengthe");

                return IsValid(mobileNumberRegex, MobileNumber);
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_NULL, "mobile number should not be null");
            }
        }
        public bool ValidatePassword(string Password)
        {
            //validat the passsword
            Func<Regex, string, bool> IsValid = (reg, field) => reg.IsMatch(field);

            try
            {
                if (Password.Length.Equals(0))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_EMPTY, "password should not be empty");
                if (Password.Length < 8)
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_MINIMUM_LENGTH, "password should not be less than minimum lengthe");
                return IsValid(passwordRegex, Password);
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_NULL, "password should not be null");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome userregistration");
        }
    }
}
