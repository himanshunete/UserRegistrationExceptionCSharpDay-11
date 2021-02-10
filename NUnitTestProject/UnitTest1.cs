using NUnit.Framework;
using UserRegistrationTestException;

namespace NUnitTestProject
{
    public class Tests
    {
        UserRegistrationTest userRegistration;
        [SetUp]
        public void Setup()
        {
            userRegistration = new UserRegistrationTest();
        }

        [Test]
        public void Given_FirstName_Expecting_TrueResult()
        {
            string[] patternFirstName = { "Himanshu", "vineet" };
            string actual = " ";
            try
            {
                actual = userRegistration.FirstName(patternFirstName);
            }
            catch (UserRegistrationTestCustomException exception)
            {
                Assert.AreEqual("FirstName is not valid", exception.Message);
            }
        }
       


           
    }
}