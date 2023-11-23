using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RedeSocial.App;
using RedeSocial.App.Componentes;
using RedeSocial.App.Login;
using RedeSocial.App.Model;
using RedeSocial.App.Models;
using RedeSocial.Domain.Base;
using RedeSocial.Domain.Entities;
using RedeSocial.Repository.Context;
using RedeSocial.Repository.Repository;
using RedeSocial.Service.Services;

namespace RedeSocial.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            Services.AddDbContext<MySqlContext>(options =>
            {
                var strCon = File.ReadAllText("C:/Users/Giova/OneDrive - ifsp.edu.br/Documentos/6semestre/POOE/RedeSocial/RedeSocial.App/Config/DatabaseSettings.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);

                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            Services.AddScoped<IBaseRepository<Amizade>, BaseRepository<Amizade>>();
            Services.AddScoped<IBaseRepository<Postagem>, BaseRepository<Postagem>>();
            Services.AddScoped<IBaseRepository<Curtida>, BaseRepository<Curtida>>();
            Services.AddScoped<IBaseRepository<Comentario>, BaseRepository<Comentario>>();

            // Services
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            Services.AddScoped<IBaseService<Amizade>, BaseService<Amizade>>();
            Services.AddScoped<IBaseService<Postagem>, BaseService<Postagem>>();
            Services.AddScoped<IBaseService<Curtida>, BaseService<Curtida>>();
            Services.AddScoped<IBaseService<Comentario>, BaseService<Comentario>>();


            // Formulários
            Services.AddTransient<Cadastro, Cadastro>();
            Services.AddTransient<Login.Login, Login.Login>();
            Services.AddTransient<BaseTelaPrincipal, BaseTelaPrincipal>();
            Services.AddTransient<InputDialogPost, InputDialogPost>();
            Services.AddTransient<InputComent, InputComent>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Usuario, UsuarioModel>();

                config.CreateMap<Amizade,AmizadeModel>()
                    .ForMember(d => d.nameUsuario1, d => d.MapFrom(x => x.Usuario1!.NomeUsuario))
                    .ForMember(d => d.nameUsuario2, d => d.MapFrom(x => x.Usuario2!.NomeUsuario));

                config.CreateMap<Postagem, PostagemModel>()
                    .ForMember(d => d.nameUsuario, d => d.MapFrom(x => x.Usuario!.NomeUsuario));

                config.CreateMap<Curtida, CurtidaModel>()
                    .ForMember(d => d.idPostagem, d => d.MapFrom(x => x.Postagem!.Id));

                config.CreateMap<Comentario, ComentarioModel>()
                    .ForMember(d => d.idPostagem, d => d.MapFrom(x => x.Postagem!.Id));

            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
