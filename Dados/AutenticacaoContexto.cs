using AutenticacaoEfCookie.Models;
using Microsoft.EntityFrameworkCore;

namespace AutenticacaoEfCookie.Dados
{
    public class AutenticacaoContexto : DbContext
    {
        public AutenticacaoContexto(DbContextOptions<AutenticacaoContexto> options) : base(options)
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Permissao> Permissao { get; set; }
        public DbSet<UsuarioPermissao> UsuarioPermissao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");
            modelBuilder.Entity<Usuario>().ToTable("Permissoes");
            modelBuilder.Entity<Usuario>().ToTable("UsuariosPermissoes");

            base.OnModelCreating(modelBuilder);
            base.SaveChanges();
        }


    }
}