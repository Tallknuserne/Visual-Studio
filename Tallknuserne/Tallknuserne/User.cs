using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tallknuserne //samme som package i Java
{
    public class User
    {
        private String username;
        private String password;
        private int role;
        private int user_id;

        public User(String username, String password, int rights, int user_id)
        {
            this.username = username;
            this.password = password;
            this.rights = rights;
            this.user_id = user_id;
        }

        public string Username
        {
            get{
                return username;
            }
            set
            {
                username = value;
            }
        }

        public String Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public int role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }

        public int User_id
        {
            get
            {
                return user_id;
            }
            set
            {
                user_id = value;
            }
        }
    }
}