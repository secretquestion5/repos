using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SimpleBase
{
    class BaseContext : DbContext
    {
        public BaseContext() : base("DefaultConnection")
        {

        }
        public DbSet<Items> Items { get; set; }
    }
}
