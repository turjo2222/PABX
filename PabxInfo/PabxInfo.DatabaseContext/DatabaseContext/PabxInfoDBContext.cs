using PabxInfo.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PabxInfo.DatabaseContext.DatabaseContext
{
    public class PabxInfoDBContext : DbContext
    {
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
