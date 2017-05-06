using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            publication a1 = new publication();
            a1.show();
            publication a2 = new publication("BookName", 152.24f);
            a2.show();
            book b1 = new book();
            b1.show();

            Console.ReadKey();
        }
    }
}
