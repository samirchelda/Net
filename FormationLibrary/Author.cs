using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationEF
{
    public class Author : IEntity

    {public int Id { set; get; }
        public string Name { set; get; }
    }
}
