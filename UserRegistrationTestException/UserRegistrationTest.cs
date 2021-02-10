using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationTestException
{
    public class UserRegistrationTest
    {
        string firstNamePattern = "^[A-Z]{1}[a-z]{2,}$";
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

    }
}
