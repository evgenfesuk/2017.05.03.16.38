using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class publication
    {
        string bookName;
        float bookPrice;

        public publication()
        {
            bookName = "N/A";
            bookPrice = 0f;
        }
        public publication(string bN, float bP)
        {
            bookName = bN;
            bookPrice = bP;
        }
        public void show()
        {
            Console.WriteLine("Book name: " + bookName);
            Console.WriteLine("Book price: " + bookPrice);
        }
    }
}
