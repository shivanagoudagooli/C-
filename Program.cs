using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp80
{
    public class User
    {
        public string name = "shiva";
        public string location = " gouda";
        public void GetUserDetails()
        {
            Console.WriteLine("name:{0}", name);
            Console.WriteLine("location:{0}", location);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.GetUserDetails();
        }
    }
}
