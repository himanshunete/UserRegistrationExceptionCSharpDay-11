using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationTestException
{
    public class UserRegistrationTestCustomException:Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            FIRST_NAME_MESSAGE,
            LAST_NAME_MESSAGE,
            EMAIL_MESSAGE,



        }
        public UserRegistrationTestCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }

}

