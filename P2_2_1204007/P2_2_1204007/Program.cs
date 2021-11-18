using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204007
{
    class Program

    {
        static void Main(string[] args)
        {



            Wattpad_1204007 mywattpad = new Wattpad_1204007("Wattpad", "Calon Imam", "186");
            Drama_1204007 drama = new Drama_1204007("EXIT", "104");

            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} pages", mywattpad.MyType, mywattpad.MyTitle, mywattpad.PageCount);
            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} minute duration", drama.MyType, drama.MyTitle, drama.Duration);
        }
    }
}
