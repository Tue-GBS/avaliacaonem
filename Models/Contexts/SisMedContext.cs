using Microsoft.EntityFrameworkCore;
using WebApplication04.Models.Entities;
using WebApplication04.Models.EntityConfigurations;
using WebApplication4.Models.Entities;
using WebApplication4.Models.EntityConfigurations;

namespace WebApplication4.Models.Contexts
{
    public class SguContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public SguContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Paciente> Pacientes => Set<Paciente>();
        public DbSet<Medico> Medicos => Set<Medico>();
        public DbSet<Consulta> Consultas => Set<Consulta>();
        public DbSet<InformacoesComplementaresPaciente> InformacoesComplementaresPaciente => Set<InformacoesComplementaresPaciente>();
        public DbSet<TipoUsuario> TipoUsuarios => Set<TipoUsuario>();
        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<TipoUtensilio> TipoUtensilios => Set<TipoUtensilio>();
        public DbSet<Utensilio> Utensilios => Set<Utensilio>();
        public DbSet<AgendamentoSolicitadoSolicita> AgendamentosSolicitadoSolicitadas => Set<AgendamentoSolicitadoSolicita>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Sgu"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new TipoUsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new TipoUsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new UtensilioConfiguration());
            modelBuilder.ApplyConfiguration(new AgendamentoSolicitadoSolicitaConfiguration());
        }
    }
}
