using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationTestException
{
    public class UserRegistrationTest
    {
        string firstNamePattern = "^[A-Z]{1}[a-z]{2,}$";
        string lastNamePattern = "^[A-Z]{1}[a-z]{2,}$";
        string emailPattern = "^[0-9a-zA-Z]+([._+-]?[0-9a-zA-Z]+)*@[0-9A-Za-z]+.([c]{1}[o]{1}[m]{1})*([n]{1}[e]{1}[t]{1})*[,]*([.][a]{1}[u]{1})*([.][c]{1}[o]{1}[m]{1})*$";
        string mobileNumberPattern = "^[9]{1}[1]{1}[ ][0-9]{10}$";
        string passwordPattern = "^[A-Z]{1}[a-zA-Z]{7,}([0-9]+)[@#$%^&*+-_]{1}$";
        /// <summary>
        /// FirstName Custom Exception
        /// </summary>
        /// <param name="patternFirstName"></param>
        /// <returns></returns>
        public string FirstName(string[] patternFirstName)
        {
            Regex regex = new Regex(firstNamePattern);
            var result = regex.Match(patternFirstName[1]);
            try
            { 

                if (!result.Success)
                {
                    throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.FIRST_NAME_MESSAGE, "FirstName is not valid");
                }
                return "FirstName is valid"; 
            }
            catch
            {
                throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.FIRST_NAME_MESSAGE, "FirstName is not valid");
            }
        }

        /// <summary>
        /// LastName Custom Exception
        /// </summary>
        /// <param name="patternLastName"></param>
        /// <returns></returns>
        public string LastName(string[] patternLastName)
        {
            Regex regex = new Regex(lastNamePattern);
            var result = regex.Match(patternLastName[1]);
            try
            {


                if (!result.Success)
                {
                    throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.LAST_NAME_MESSAGE, "LastName is not valid");
                }
                return "LastName is valid";
            }
            catch
            {
                throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.LAST_NAME_MESSAGE, "LastName is not valid");
            }
        }

        /// <summary>
        /// Email Custom Exception
        /// </summary>
        /// <param name="patternEmail"></param>
        /// <returns></returns>
        public string EmailAddress(string patternEmail)
        {
            Regex regex = new Regex(emailPattern);
            var result = regex.Match(patternEmail);
            try
            {


                if (!result.Success)
                {
                    throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.EMAIL_MESSAGE, "Email is not valid");
                }
                return "Email is valid";
            }
            catch
            {
                throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.EMAIL_MESSAGE, "Email is not valid");
            }
        }

        /// <summary>
        /// Password Custom Exception
        /// </summary>
        /// <param name="patternPassword"></param>
        /// <returns></returns>
        public string Password(string[] patternPassword)
        {
            Regex regex = new Regex(passwordPattern);
            var result = regex.Match(patternPassword[1]);
            try
            {


                if (!result.Success)
                {
                    throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.PASSWORD_MESSAGE, "Password is not valid");
                }
                return "Password is valid";
            }
            catch
            {
                throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.PASSWORD_MESSAGE, "Password is not valid");
            }
        }


        /// <summary>
        /// Mobile Number Custom Exception
        /// </summary>
        /// <param name="patternMobileNumber"></param>
        /// <returns></returns>
        public string MobileNumber(string[] patternMobileNumber)
        {
            Regex regex = new Regex(mobileNumberPattern);
            var result = regex.Match(patternMobileNumber[0]);
            try
            {


                if (!result.Success)
                {
                    throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.MOBILE_NUMBER_MESSAGE, "Mobile Number is not valid");
                }
                return "Mobile Number is valid";
            }
            catch
            {
                throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.MOBILE_NUMBER_MESSAGE, "Mobile Number is not valid");
            }
        }

    }
}
