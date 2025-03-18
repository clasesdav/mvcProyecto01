
using Microsoft.EntityFrameworkCore;
using mvcProyecto.Models;

namespace mvcProyecto.Data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }
        //Aqui todos los modelos que se creen 
        public DbSet<Producto> Producto { get; set; }

        public DbSet<Almacen> Almacen { get; set; }

    }
}
