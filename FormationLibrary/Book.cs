using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationEF
{
    public class Book : Media
    {
        public int NbrPage { set; get;}

        public override double VATPrice
        {
            get
            {
                return Price*1.05;
            }
        }
    }
}
