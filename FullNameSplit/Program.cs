using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullNameSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = " Emilia Isobel  Euphemia Rose  Clarke ";

            var result = SplitFullName.FullNameSplitter(name, 1);

            Console.WriteLine("Not-Normalize Name: " + name);
            Console.WriteLine("Normalize Full Name: " + result.NormalizeFullName);
            Console.WriteLine("First Name: " + result.Firstname);
            Console.WriteLine("Surname Name: " + result.SurName);
            Console.WriteLine("Middle Names: " + result.MiddleNames);
            Console.ReadLine();
        }
    }
}
