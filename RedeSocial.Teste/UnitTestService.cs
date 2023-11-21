using System.Text.Json;
using AutoMapper;
using RedeSocial.Domain.Base;
using RedeSocial.Domain.Entities;
using RedeSocial.Repository.Context;
using RedeSocial.Repository.Repository;
using RedeSocial.Service.Services;
using RedeSocial.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RedeSocial.Teste
{
    [TestClass]
    public class UnitTestService
    {
        private ServiceCollection? services;


        public ServiceProvider ConfiguraServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "RedeSocial";
                var username = "root";
                var password = "";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();

            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Usuario, Usuario>(); }).CreateMapper());

            services.AddScoped<IBaseRepository<Amizade>, BaseRepository<Amizade>>();
            services.AddScoped<IBaseService<Amizade>, BaseService<Amizade>>();

            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Amizade, Amizade>(); }).CreateMapper());

            services.AddScoped<IBaseRepository<Postagem>, BaseRepository<Postagem>>();
            services.AddScoped<IBaseService<Postagem>, BaseService<Postagem>>();

            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Postagem, Postagem>(); }).CreateMapper());

            services.AddScoped<IBaseRepository<Comentario>, BaseRepository<Comentario>>();
            services.AddScoped<IBaseService<Comentario>, BaseService<Comentario>>();

            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Comentario, Comentario>(); }).CreateMapper());


            services.AddScoped<IBaseRepository<Curtida>, BaseRepository<Curtida>>();
            services.AddScoped<IBaseService<Curtida>, BaseService<Curtida>>();

            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Curtida, Curtida>(); }).CreateMapper());
            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestUsuario()
        {
            var sp = ConfiguraServices();
            var _usuarioService = sp.GetService<IBaseService<Usuario>>();

            var usuario = new Usuario
            {
                NomeUsuario = "Giovanna",
                NomeCompleto = "Giovanna Santos Fantacini",
                Email = "giovanna@mail.com",
                Senha = "123",
                DataDeRegistro = DateTime.Now
 
        };

            var result = _usuarioService?.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            var usuarios = _usuarioService.Get<Usuario>().ToList();
            Console.WriteLine(JsonSerializer.Serialize(usuarios));
        }

        [TestMethod]
        public void TestAmizade()
        {
            var sp = ConfiguraServices();
            var _amizadeService = sp.GetService<IBaseService<Amizade>>();

            var usuario1 = new Usuario
            {
                NomeUsuario = "Usuario1",
                Email = "usuario1@mail.com",
                Senha = "123",
                DataDeRegistro = DateTime.Now
            };

            var usuario2 = new Usuario
            {
                NomeUsuario = "Usuario2",
                Email = "usuario2@mail.com",
                Senha = "123",
                DataDeRegistro = DateTime.Now
            };

            var amizade = new Amizade
            {
                Usuario1 = usuario1,
                Usuario2 = usuario2,
                EstadoAmizade = "Amigos"
            };

            var result = _amizadeService?.Add<Amizade, Amizade, AmizadeValidator>(amizade);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestPostagem()
        {
            var sp = ConfiguraServices();
            var _postagemService = sp.GetService<IBaseService<Postagem>>();

            var usuario = new Usuario
            {
                NomeUsuario = "giovanna",
                Email = "giovanna@mail.com",
                Senha = "123",
                DataDeRegistro = DateTime.Now
            };

            var postagem = new Postagem
            {
                Usuario = usuario,
                TextoDaPostagem = "Conteúdo da postagem de teste",
                DataHoraPostagem = DateTime.Now
            };

            var result = _postagemService?.Add<Postagem, Postagem, PostagemValidator>(postagem);
           
            Console.WriteLine(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestComentario()
        {
            var sp = ConfiguraServices();
            var _comentarioService = sp.GetService<IBaseService<Comentario>>();

            var usuario = new Usuario
            {
                NomeUsuario = "giovanna",
                Email = "giovanna@mail.com",
                Senha = "123",
                DataDeRegistro = DateTime.Now
            };

            var postagem = new Postagem
            {
                Usuario = usuario,
                TextoDaPostagem = "Conteúdo da postagem para comentário",
                DataHoraPostagem = DateTime.Now
            };

            var comentario = new Comentario
            {
                Postagem = postagem,
                Usuario = usuario,
                TextoComentario = "Comentário de teste",
                DataHoraComentario = DateTime.Now
            };

            var result = _comentarioService?.Add<Comentario, Comentario, ComentarioValidator>(comentario);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestCurtida()
        {
            var sp = ConfiguraServices();
            var _curtidaService = sp.GetService<IBaseService<Curtida>>();

            var usuario = new Usuario
            {
                NomeUsuario = "giovanna",
                Email = "giovanna@mail.com",
                Senha = "123",
                DataDeRegistro = DateTime.Now
            };

            var postagem = new Postagem
            {
                Usuario = usuario,
                TextoDaPostagem = "Conteúdo da postagem para curtida",
                DataHoraPostagem = DateTime.Now
            };

            var curtida = new Curtida
            {
                Postagem = postagem,
                Usuario = usuario,
                DataHoraCurtida = DateTime.Now
            };

            var result = _curtidaService?.Add<Curtida, Curtida, CurtidaValidator>(curtida);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }



    }
}