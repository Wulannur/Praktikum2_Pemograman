using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204007
{
    public class Drama_1204007 : Product_1204007
    {
        protected string duration;

        public Drama_1204007(string title, string duration)
        {
            this.MyTitle = title;
            this.Duration = duration;
            this.MyType = "Drama";

            Console.WriteLine("Drama Rekomendasi");
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