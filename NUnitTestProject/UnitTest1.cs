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

        /// <summary>
        /// TC-1 Throw Custom Exception for Invalid FirstName
        /// </summary>
        [Test]
        public void Given_FirstName_Expecting_ThrowCustomException()
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

        /// <summary>
        /// TC-2 Throw Custom Exception for Invalid LastName
        /// </summary>
        [Test]
        public void Given_LastName_Expecting_ThrowCustomException()
        {
            string[] patternLastName = { "Nete", "kadwe" };
            string actual = " ";
            try
            {
                actual = userRegistration.LastName(patternLastName);
            }
            catch (UserRegistrationTestCustomException exception)
            {
                Assert.AreEqual("LastName is not valid", exception.Message);
            }
        }

        /// <summary>
        /// TC-3 Throw Custom Exception for Invalid Email
        /// </summary>
        [Test]
        public void Given_Email_Expecting_ThrowCustomException()
        {
            string[] patternEmail = { "himnshuneteh@gmil.com", "vineetkdwe@gmil.com" };
            string actual = " ";
            try
            {
                actual = userRegistration.EmailAddress(patternEmail);
            }
            catch (UserRegistrationTestCustomException exception)
            {
                Assert.AreEqual("Email is not valid", exception.Message);
            }
        }

        /// <summary>
        /// TC-4 Throw Custom Exception for Invalid Mobile Number
        /// </summary>
        [Test]
        public void Given_MobileNumber_Expecting_ThrowCustomException()
        {
            string[] patternMobileNumber = { "91 8803829504", "7378138447" };
            string actual = " ";
            try
            {
                actual = userRegistration.MobileNumber(patternMobileNumber);
            }
            catch (UserRegistrationTestCustomException exception)
            {
                Assert.AreEqual("Mobile Number is not valid", exception.Message);
            }
        }

        /// <summary>
        /// TC-5 Throw Custom Exception for Invalid Password
        /// </summary>
        [Test]
        public void Given_Password_Expecting_ThrowCustomException()
        {
            string[] patternPassword = { "Himanshunete18$", "Vineetkdwe9##" };
            string actual = " ";
            try
            {
                actual = userRegistration.Password(patternPassword);
            }
            catch (UserRegistrationTestCustomException exception)
            {
                Assert.AreEqual("Password is not valid", exception.Message);
            }
        }



    }
}