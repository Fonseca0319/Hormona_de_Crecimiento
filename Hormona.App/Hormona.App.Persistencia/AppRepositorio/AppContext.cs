using Microsoft.EntityFrameworkCore;
using Hormona.App.Dominio;
namespace Hormona.App.Persistencia;

public class AppContext : DbContext
{
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Pediatra> Pediatras { get; set; }
    public DbSet<Endocrino> Endocrinos { get; set; }
    public DbSet<Historia> Historias { get; set; }
    public DbSet<SugerenciasDeCiudado> sugerencias { get; set; }
    public DbSet<Paciente> Pacientes { get; set; }
   
    public DbSet<Familiar> Familiares { get; set; }
    public DbSet<PatronDeCrecimineto> Patrones {get; set;}
      public AppContext (DbContextOptions<AppContext> options)
            : base(options)
        {
        }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HormonaDeCreciminento");
        }
    }

}