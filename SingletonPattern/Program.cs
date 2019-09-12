using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonClass xxx = SingletonClass.Instance;


            SingletonClassExample yyy =  SingletonClassExample.GetInstance();
            Console.WriteLine(yyy.Id.ToString());

            SingletonClassExample ccc = SingletonClassExample.GetInstance();
            Console.WriteLine(ccc.Id.ToString());
        }
    }
}
