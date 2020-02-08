using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincessPasswordKeeper
{
    class Autentication
    {
        static string login;
        static string password;

        public static void enter(string login1, string password1)
        {
            login = login1;
            password = password1;
        }

        public static void exit()
        {
            login = null;
            password = null;
        }
    }
}
