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
        /// <param name="patternFirstName"></param>
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



    }
}
