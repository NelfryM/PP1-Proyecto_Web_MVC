using Microsoft.EntityFrameworkCore;
using PP1_Proyecto_Web_MVC.Models;

namespace PP1_Proyecto_Web_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)

             : base(options) 
        {
        
        }

        public DbSet<Asignatura> Asignaturas { get; set; }

    }
}
