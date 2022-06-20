using System;
using System.Collections.Generic;
using System.Text;

namespace LevelEntities
{
    public class User
    {
        public int ID { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }

        public User() { }

        public User(int ID, String UserName, String Password)
        {
            this.ID = ID;
            this.UserName = UserName;
            this.Password = Password;
        }
    }
}
