 using NUnit.Framework;
 using UserregistrationDay10;
namespace Userregstration
    {
        public class Tests
        {
            Useregex useregex;
            [SetUp]
            public void Setup()
            {
                useregex = new Useregex();
            }
            //TC1. Validtate first name

            [Test]

            public void GivenFirstName_WhenValid_ShouldReturnTrue()
            {
                bool result = useregex.ValidateFirstName("Sonal");
                Assert.IsTrue(result);
            }

            //TC1.1:Check first name should not be null
            [Test]
            public void GivenFirstName_WhenNull_ShouldThrowCustomException()
            {
                try
                {
                    bool result = useregex.ValidateFirstName(null);
                }
                catch (UserRegistrationException exception)
                {
                    Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_NULL, exception.exceptionType);
                }
            }
            //TC1.2:Check first name should conatins minimum length
            [Test]
            public void GivenFirstName_WhenLessThanMinimumLength_ShouldThrowCustomException()
            {
                try
                {
                    bool result = useregex.ValidateFirstName("Ka");
                }
                catch (UserRegistrationException exception)
                {
                    Assert.AreEqual(UserRegistrationException.ExceptionType.MINIMUM_THREE_LETTER, exception.exceptionType);
                }
            }
            //TC1.3: First name should not be empty
            [Test]
            public void GivenFirstName_WhenEmpty_ShouldThrowCustomException()
            {
                try
                {
                    bool result = useregex.ValidateFirstName("");
                }
                catch (UserRegistrationException exception)
                {
                    Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_EMPTY, exception.exceptionType);
                }
            }
            //TC2: validate the last name
            public void GivenlastName_WhenValid_ShouldReturnTrue()
            {
                bool result = useregex.ValidateLastName("Karle");
                Assert.IsTrue(result);
            }

            //TC2.1: Given last name as per pattern
            [Test]

            public void Given_lastName_WhenValid_ShouldReturnTrue()
            {
                bool result = useregex.ValidateFirstName("Karle");
                Assert.IsTrue(result);
            }


            //TC2.1: Last name should not be null
            [Test]
            public void GivenLastName_WhenNull_ShouldThrowCustomException()
            {
                try
                {
                    bool result = useregex.ValidateLastName(null);
                }
                catch (UserRegistrationException exception)
                {
                    Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_NULL, exception.exceptionType);
                }
            }
            //TC2.2: Check last name with minimum letter

            [Test]
            public void GivenLastName_WhenLessThanMinimumLength_ShouldThrowCustomException()
            {
                try
                {
                    bool result = useregex.ValidateLastName("Ka");
                }
                catch (UserRegistrationException exception)
                {
                    Assert.AreEqual(UserRegistrationException.ExceptionType.MINIMUM_THREE_LETTER, exception.exceptionType);
                }
            }
            //TC2.3: Last name should not be empty
            [Test]
            public void GivenLastName_WhenEmpty_ShouldThrowCustomException()
            {
                try
                {
                    bool result = useregex.ValidateLastName("");
                }
                catch (UserRegistrationException exception)
                {
                    Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_EMPTY, exception.exceptionType);
                }
            }
            //TC3 : validate the email id
            public void GivenemailID_WhenValid_ShouldReturnTrue()
            {
                bool result = useregex.ValidateEmailAddress("abc@bridgelabz.com");
                Assert.IsTrue(result);
            }
            //TC3.1: Email Id should not be null
            [Test]

            public void GivenEmailAddress_WhenNull_ShouldThrowCustomException()
            {
                try
                {
                    bool result = useregex.ValidateEmailAddress(null);
                }
                catch (UserRegistrationException exception)
                {
                    Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_NULL, exception.exceptionType);
                }
            }
            //TC3.2:Email Id should not be empty
            [Test]
            public void GivenEmailAddress_WhenEmpty_ShouldThrowCustomException()
            {
                try
                {
                    bool result = useregex.ValidateEmailAddress("");
                }
                catch (UserRegistrationException exception)
                {
                    Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_EMPTY, exception.exceptionType);
                }
            }
            //TC3.3: Email ID maintain minimum length
            [Test]
            public void GivenEmailAddress_WhenLessThanMinimumLength_ShouldThrowCustomException()
            {
                try
                {
                    bool result = useregex.ValidateEmailAddress("k@.co");
                }
                catch (UserRegistrationException exception)
                {
                    Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_MINIMUM_LENGTH, exception.exceptionType);
                }
            }
        //TC4 : validate the phone number
        public void Givenmobilenum_WhenValid_ShouldReturnTrue()
        {
            bool result = useregex.ValidateMobileNumber("9702420754");
            Assert.IsTrue(result);
        }
        //TC4.1:Phone number should not be null
        public void GivenMobileNumber_WhenNull_ShouldThrowCustomException()
        {
            try
            {
                bool result = useregex.ValidateMobileNumber(null);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_NULL, exception.exceptionType);
            }

        }
        //TC4.2: phone number should not be blank
        [Test]
        public void GivenMobileNumber_WhenEmpty_ShouldThrowCustomException()
        {
            try
            {
                bool result = useregex.ValidateMobileNumber("");
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_EMPTY, exception.exceptionType);
            }
        }
        //TC4.3: Given number should follow the length
        [Test]
        public void GivenMobileNumber_WhenLessThanMinimumLength_ShouldThrowCustomException()
        {
            try
            {
                bool result = useregex.ValidateMobileNumber("00 123456789");
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_MINIMUM_LENGTH, exception.exceptionType);
            }
        }




    }
}