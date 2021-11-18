using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204007
{
    public class Wattpad_1204007 : Product_1204007
    {
        protected string pageCount;

        public Wattpad_1204007(string mytype, string mytitle, string pagecount) : base(mytype, mytitle)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get

            {
                return pageCount;
            }

            set
            {
                pageCount = value;
            }
        }

    }
}
