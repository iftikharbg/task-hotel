using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int ID { get; set; }
        public string Password { get; set; }

        public static int id = 1;




        public User(string n, string s, string e,string u)
        {
            Name = n;
            Surname = s;
            Email = e;
            Username = u;
            ID = id;
            id++;
        }
    }
}

