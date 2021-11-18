using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204007
{
    public class Dvd_1204007 : Product_1204007
    {
        protected string duration;

        public Dvd_1204007(string title, string duration)
        {
            this.MyTitle = title;
            this.Duration = duration;
            this.MyType = "DVD";

            Console.WriteLine("Ini dari class DVD");
        }

        public string Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }
    }
}
