using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureAPI.Modules
{
    public class Context: DbContext
    {
        public Context()
        {

        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {

        }

        public virtual DbSet<Adventure> Adventure { get; set; }
        public virtual DbSet<Character> Character { get; set; }
    }
}
