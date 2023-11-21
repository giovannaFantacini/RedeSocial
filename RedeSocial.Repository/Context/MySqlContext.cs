using RedeSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RedeSocial.Repository.Mappings;

namespace RedeSocial.Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Usuario>? Usuario { get; set; }
        public DbSet<Postagem>? Postagem { get; set; }
        public DbSet<Curtida>? Curtida { get; set; }
        public DbSet<Comentario>? Comentario { get; set; }
        public DbSet<Amizade>? Amizade { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);            
            modelBuilder.Entity<Postagem>(new PostagemMap().Configure);
            modelBuilder.Entity<Curtida>(new CurtidaMap().Configure);
            modelBuilder.Entity<Comentario>(new ComentarioMap().Configure);
            modelBuilder.Entity<Amizade>(new AmizadeMap().Configure);
        }
    }
}
