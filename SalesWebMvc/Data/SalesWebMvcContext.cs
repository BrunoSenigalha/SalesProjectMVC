using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;
<<<<<<< HEAD
=======
using SalesWebMvc.Models.Enums;
>>>>>>> 05c9177 (Adding other entities and second migration)

namespace SalesWebMvc.Data
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext (DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
<<<<<<< HEAD
=======
        public DbSet<Seller> Sellers { get; set; } = default!;
        public DbSet<SalesRecord> SalesRecords { get; set; } = default!;
>>>>>>> 05c9177 (Adding other entities and second migration)
    }
}
