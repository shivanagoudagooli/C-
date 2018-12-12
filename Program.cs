using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67
{
    interface IUser
    {
        void GetDetails(string x);
    }

    class User:IUser
    {
        public void GetDetails(string a)
        {
            Console.WriteLine("Name:{0}", a);
        }
    }

     class User1:IUser
    {
        public void GetDetails(string a)
        {
            Console.WriteLine("location:{0}", a);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            IUser u = new User();
            u.GetDetails("shiva");

            User1 u1 = new User1();
            u1.GetDetails("hadagali");
            Console.ReadLine();

        }
    }

    
}
