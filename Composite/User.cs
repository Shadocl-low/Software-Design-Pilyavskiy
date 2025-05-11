using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class User
    {
        public bool IsAutorized { get; private set; } = false;
        private readonly string Name;
        private readonly string Password;
        public User(string name, string password) 
        {
            Name = name;
            Password = password;
        }
        public bool Autorize()
        {
            if (Name == "Admin" && Password == "SuperPassword")
            {
                IsAutorized = true;
            }

            return IsAutorized;
        }
    }
}
