using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Datatables.Models
{
    public class Context : DbContext
    {
        public DbSet<Person> Person { get; set; }
    }
}