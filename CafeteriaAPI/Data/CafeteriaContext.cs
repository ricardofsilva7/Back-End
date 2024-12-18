using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cafeteria.Models;

namespace CafeteriaAPI.Data
{
    public class CafeteriaContext : DbContext
    {
        public CafeteriaContext (DbContextOptions<CafeteriaContext> options)
            : base(options)
        {
        }

        public DbSet<Cafeteria.Models.Product> Product { get; set; } = default!;
    }
}
