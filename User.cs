using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class User : IAccount
    {
        public User(string password)
        {
            this.Password = password;
        }

        public User()
        {
        }

        public string FullName { get; set; }
        private string _password;

        internal bool ShowInfo()
        {
            throw new NotImplementedException();
        }

        public string Email { get; set; }

        public string Password
        {
            get => this._password;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length < 9)
                    this._password = value;
            }
        }

        public bool HasUpper(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsUpper(str[i]))
                        return true;
                }
            }

            return false;
        }

        public bool HasLower(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsLower(str[i]))
                        return true;
                }
            }

            return false;
        }

        public bool HasDigit(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]))
                        return true;
                }
            }

            return false;
        }

        public string PasswordChecker()
        {
            throw new NotImplementedException();
        }
    }
}
