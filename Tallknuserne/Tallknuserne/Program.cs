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
        private int rights;
        private int user_id;

        public User(String username, String password, int rights, int user_id)
        {
            this.username = username;
            this.password = password;
            this.rights = rights;
            this.user_id = user_id;
        }

        public String getUsername()
        {
            return username;
        }

        public String getPassword()
        {
            return password;
        }

        public int getRights()
        {
            return rights;
        }

        public int getUser_id()
        {
            return user_id;
        }

        public void setUsername(String newName)
        {
            username = newName;
        }

        public void setPassword(String newPassword)
        {
            password = newPassword;
        }

        public void setRights(int newRights)
        {
            rights = newRights;
        }



    }
}