using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IService
    {
        public void AddUsers();

        public void DeleteUsers();

        public void CheckIn(User u);
        public void CheckOut();

        



    }
}
