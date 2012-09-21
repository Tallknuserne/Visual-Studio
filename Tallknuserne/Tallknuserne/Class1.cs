using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tallknuserne
{
    public class Teacher : User
    {
        public Teacher(String username, String password, int rights, int user_id)
            : base(username, password, rights, user_id)
        {
        }
    }
    
    public class Student : User
    {
        public Student(String username, String password, int rights, int user_id)
            : base(username, password, rights, user_id)
        {
        }
    }
}
