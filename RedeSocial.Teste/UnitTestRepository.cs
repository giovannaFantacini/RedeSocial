using System.Text.Json;
using RedeSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace RedeSocial.Teste
{
    [TestClass]
    public class UnitTestRepository
    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<Usuario> Usuario { get; set; }
            public DbSet<Postagem> Postagem { get; set; }
            public DbSet<Comentario> Comentario { get; set; }
            public DbSet<Curtida> Curtida { get; set; }
            public DbSet<Amizade> Amizade { get; set; }

            public MyDbContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "RedeSocial";
                var username = "root";
                var password = "";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";

                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Configurações adicionais do modelo, se necessário
            }
        }

        [TestMethod]
        public void TestInsertEntities()
        {
            using (var context = new MyDbContext())
            {


                var usuario = new Usuario
                {
                    NomeUsuario = "Giovanna",
                    Email = "giovanna@mail.com",
                    Senha = "123",
                    DataDeRegistro = DateTime.Now
                };

                var postagem = new Postagem
                {
                    Usuario = usuario,
                    TextoDaPostagem = "Postagem de teste",
                    DataHoraPostagem = DateTime.Now
                };

                var comentario = new Comentario
                {
                    Postagem = postagem,
                    Usuario = usuario,
                    TextoComentario = "Comentário de teste",
                    DataHoraComentario = DateTime.Now
                };

                var curtida = new Curtida
                {
                    Postagem = postagem,
                    Usuario = usuario,
                    DataHoraCurtida = DateTime.Now
                };

                var amizade = new Amizade
                {
                    Usuario1 = usuario,
                    Usuario2 = usuario,
                    EstadoAmizade = "Amigos"
                };


                context.Usuario.Add(usuario);
                context.Postagem.Add(postagem);
                context.Comentario.Add(comentario);
                context.Curtida.Add(curtida);
                context.Amizade.Add(amizade);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListarUsuarios()
        {
            using (var context = new MyDbContext())
            {

                foreach (var usuario in context.Usuario)
                {
                    Console.WriteLine($"ID: {usuario.Id}, Nome: {usuario.NomeUsuario}, Email: {usuario.Email}");
                }
            }
        }
    }
}
