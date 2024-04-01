using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13
{
    internal class Users
    {
        public static List<Users> user = new List<Users>();
        public string Login { get; set; }
        public int Password { get; set; }
        public List<Users> users { get; set; }
        public Users(string _Login, int _Password)
        {
            Login = _Login;
            Password = _Password;
            user = users;
        }
    }
}
