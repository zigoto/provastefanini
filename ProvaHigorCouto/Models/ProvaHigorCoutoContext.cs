using System.Linq;

namespace ProvaHigorCouto.Models
{
    using Microsoft.EntityFrameworkCore;

    public partial class ProvaHigorCoutoContext : DbContext
    {
        public virtual DbSet<Usuario> usuario { get; set; }
        public virtual DbSet<Perfil> perfil { get; set; }
        public virtual DbSet<Funcionalidade> funcionalidade { get; set; }
        public virtual DbSet<FuncionalidadePerfil> funcionalidadePerfil { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"data source=localhost;initial catalog=ProvaHigorCouto;Integrated Security=SSPI;");
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Usuario>()
            //    .HasOne(u => u.Perfil)
            //    .WithMany(p => p.Usuarios);

            //modelBuilder.Entity<FuncionalidadePerfil>()
            //    .HasOne(f => f.Funcionalidade)
            //    .WithMany(p => p.FuncionalidadesPerfil);

            //modelBuilder.Entity<FuncionalidadePerfil>()
            //    .HasOne(f => f.Perfil)
            //    .WithMany(p => p.FuncionalidadesPerfil);

            base.OnModelCreating(modelBuilder);
        }
    }
}