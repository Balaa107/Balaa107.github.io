using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Question2
    {
        public static int Splitstr(string str)
        {
             int parts = str.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Length + 1;
            return parts;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter The String :-");
            string str = Console.ReadLine();
            
            Console.WriteLine(Splitstr(str));
            Console.ReadKey();
        }
    }
}
