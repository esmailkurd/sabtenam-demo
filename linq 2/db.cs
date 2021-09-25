using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace linq_2
{
    class db:DbContext
    {
        public db () : base("constr") { }
        public DbSet<human> jadval { set; get; }
    }
}
