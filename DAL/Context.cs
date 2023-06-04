using Microsoft.EntityFrameworkCore;
using Practicas1.Models;

namespace Practicas1.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> Options) 
            :base(Options) { }

        public DbSet<Pruebas> Pruebas { get; set; }
    }
}
