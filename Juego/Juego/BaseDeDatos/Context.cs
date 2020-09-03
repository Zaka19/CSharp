using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Juego.BaseDeDatos
{
    class Context : DbContext
    {
        public Context()
        {
            this.Database.Migrate();
        }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Dungeon;Trusted_Connection=True;");
            }
        }
        public DbSet<Jugador> Jugadores { get; set; }
    }
}
