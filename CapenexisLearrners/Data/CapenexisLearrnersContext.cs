using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CapenexisLearrners.Models;

namespace CapenexisLearrners.Data
{
    public class CapenexisLearrnersContext : DbContext
    {
        public CapenexisLearrnersContext (DbContextOptions<CapenexisLearrnersContext> options)
            : base(options)
        {
        }

        public DbSet<CapenexisLearrners.Models.Movie> Movie { get; set; } = default!;
    }
}
