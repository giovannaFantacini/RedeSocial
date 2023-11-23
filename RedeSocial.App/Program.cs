


using Microsoft.Extensions.DependencyInjection;
using RedeSocial.App.Infra;
using RedeSocial.Domain.Base;
using RedeSocial.Domain.Entities;

namespace RedeSocial.App.Login
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureDI.ConfiguraServices();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var postService = ConfigureDI.ServicesProvider!.GetService<IBaseService<Postagem>>();
            var amizadeService = ConfigureDI.ServicesProvider!.GetService<IBaseService<Amizade>>();
            var userService = ConfigureDI.ServicesProvider!.GetService<IBaseService<Usuario>>();
            var curtidaService = ConfigureDI.ServicesProvider!.GetService<IBaseService<Curtida>>();
            var commentService = ConfigureDI.ServicesProvider!.GetService<IBaseService<Comentario>>();
            ApplicationConfiguration.Initialize();
            Application.Run(new BaseTelaPrincipal(postService, amizadeService, userService, curtidaService, commentService));
        }
    }
}