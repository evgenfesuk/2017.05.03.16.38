using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class book : publication
    {
        public book()
        {
            new publication("test", 1.0f);
        }
        public book(string bN, float bP)
        {
            new publication(bN, bP);
        }
    }
}
