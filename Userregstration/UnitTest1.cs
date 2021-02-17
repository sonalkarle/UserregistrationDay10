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
        //TC1.1: Given first name as per pattern
        [Test]

        public void GivenFirstName_WhenValid_ShouldReturnTrue()
        {
            bool result = useregex.ValidateFirstName("Sonal");
            Assert.IsTrue(result);
        }
        //TC1.2: Check first name by contain minimum three letter
        [Test]
        public void GivenFirstName_WhenInvalid_ShouldThrowCustomException()
        {
            try
            {
                bool result = useregex.ValidateFirstName("karle");
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.MINIMUM_THREE_LETTER, exception.exceptionType);
            }
        }

    }
}