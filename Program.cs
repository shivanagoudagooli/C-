using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp122
{
    class Program
    {
        static void Main(string[] args)
        {


            string s = "shiva    goud";
            string g = string.Copy(s);
            Console.WriteLine(s.TrimStart(trimChars));
            //Console.WriteLine(object.ReferenceEquals(s, g));




            // string s = "Name:{0} {1}, Location:{2}, Age:{3}";
            //string d = string.Format(s,"shivana","gouda","bangalore",44);
            //Console.WriteLine(d);
            //Console.WriteLine(d.Remove(0, 5));
            //string g = "loki";
            //Console.WriteLine(string.Compare(d, g));
            //string s = "shivanagouda gouda is going to be rich";
            //Console.WriteLine("Substring:{0}", s.Substring(0, 5));
            //string g = "gouda";
            //StringComparison comp = StringComparison.OrdinalIgnoreCase;
            //bool reult = s.IndexOf(s, comp) > 0 ? true : false;
            //Console.WriteLine("it is correct:{0}", s.Contains(g));
            /*string s = "shiva";
            string g = "gouda";
            Console.WriteLine("new:{0}", string.Concat(s, g));
            
            
            
            
            string msg = "hi Guest hi";
            string nmsg = msg.Replace("hi", "welcome");
            Console.WriteLine("Old:{0},New:{1}", msg, nmsg);
             */
        }
    }
}
