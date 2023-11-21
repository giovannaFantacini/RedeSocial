
namespace RedeSocial.App.Models
{
    public class PostagemModel
    {
        public string nameUsuario { get; set; }
        public string? TextoDaPostagem { get; set; }
        public DateTime DataHoraPostagem { get; set; }
    }

    public class CurtidaModel
    {
      
        public string nameUsuario { get; set; }
        public int idPostagem { get; set; }
        public DateTime DataHoraCurtida { get; set; }

    }

    public class ComentarioModel
    {
        public int idPostagem { get; set; }
        public int idUsuario { get; set; }
        public string? TextoComentario { get; set; }
        public DateTime DataHoraComentario { get; set; }
    }
}
