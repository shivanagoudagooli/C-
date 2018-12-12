using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp100
{
    public class GenericClass<T>
    {
        public T msg;
        public void genericMethod(T name,T location)
        {
            Console.WriteLine("{0}", msg);
            Console.WriteLine("{0}", name);
            Console.WriteLine("{ 0}", location);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> gclass = new GenericClass<string>();
            gclass.msg = "welcome to generics";
            gclass.genericMethod("Suresh","Hadagali");
            Console.ReadLine();
        }
    }
}
