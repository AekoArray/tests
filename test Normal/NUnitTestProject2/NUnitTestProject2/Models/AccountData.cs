using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject2
{
    public class AccountData
    {
        public AccountData(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Email { get; set; }

        public string Password { get; set; }

    }
}
