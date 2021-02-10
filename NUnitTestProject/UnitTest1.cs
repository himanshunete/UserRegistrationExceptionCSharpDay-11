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

        [TestCase("abc@yahoo.com")]
        [TestCase("abc-100@yahoo.com,")]
        [TestCase("abc.100@yahoo.com")]
        [TestCase("abc111@abc.com,")]
        [TestCase("abc-100@abc.net,")]
        [TestCase("abc.100@abc.com.au")]
        [TestCase("abc@1.com,")]
        [TestCase("abc@gmail.com.com")]
        [TestCase("abc+100@gmail.com")]
        [TestCase("abc")]
        [TestCase("abc@.com.my")]
        [TestCase("abc123@gmail.a")]
        [TestCase("abc123@.com")]
        [TestCase("abc@.com.com")]
        [TestCase(".abc@abc.com")]
        [TestCase("abc()*@gmail.com")]
        [TestCase("abc@%*.com")]
        [TestCase("abc..2002@gmail.com")]
        [TestCase("abc.@gmail.com")]
        [TestCase("abc@abc@gmail.com")]
        [TestCase("abc@gmail.com.1a")]
        [TestCase("abc@gmail.com.aa.au")]
        /// <summary>
        /// TC-6 Throw Custom Exception for Invalid Email
        /// </summary>
        [Test]
        public void Given_Email_Expecting_ThrowCustomException(string sampleEmail)
        {
        
            string actual = " ";
            try
            {
                actual = userRegistration.EmailAddress(sampleEmail);
            }
            catch (UserRegistrationTestCustomException exception)
            {
                Assert.AreEqual("Email is not valid", exception.Message);
            }
        }



    }
}