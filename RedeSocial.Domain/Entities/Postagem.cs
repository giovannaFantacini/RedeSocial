using RedeSocial.Domain.Base;
using System.Text.Json.Serialization;

namespace RedeSocial.Domain.Entities
{
    public class Postagem : BaseEntity<int>
    {
        public Postagem()
        {

        }

        public Postagem(int id, Usuario? usuario, string? textoDaPostagem, DateTime dataHoraDaPostagem) : base(id)
        {
            Usuario = usuario;
            TextoDaPostagem = textoDaPostagem;
            DataHoraPostagem = dataHoraDaPostagem;
        }

        public Usuario? Usuario { get; set; }
        public string? TextoDaPostagem { get; set; }
        public DateTime DataHoraPostagem { get; set; }
    }

    public class Curtida : BaseEntity<int>
    {
        public Curtida()
        {

        }

        public Curtida(int id, Usuario? usuario, Postagem? postagem, DateTime dataHoraCurtida) : base(id)
        {
            Usuario = usuario;
            Postagem = postagem;
            DataHoraCurtida = dataHoraCurtida;
        }

        public Usuario? Usuario { get; set; }
        [JsonIgnore]
        public Postagem? Postagem { get; set; }
        public DateTime DataHoraCurtida { get; set; }

    }

    public class Comentario : BaseEntity<int>
    {
        public Comentario()
        {

        }

        public Comentario(int id, Postagem? postagem, Usuario? usuario, string? textoComentario, DateTime dataHoraComentario) : base(id)
        {
            Postagem = postagem;
            Usuario = usuario;
            TextoComentario = textoComentario;
            DataHoraComentario = dataHoraComentario;
        }

        [JsonIgnore]
        public Postagem? Postagem { get; set; }
        public Usuario? Usuario { get; set; }
        public string? TextoComentario { get; set; }
        public DateTime DataHoraComentario { get; set; }
    }
}
