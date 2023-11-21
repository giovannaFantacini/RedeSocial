using RedeSocial.Domain.Base;

namespace RedeSocial.Domain.Entities
{
    public class Usuario : BaseEntity<int>
    {
        public Usuario()
        {

        }

        public Usuario(int id, string? nomeUsuario, string? nomeCompleto, DateTime? dataDeRegistro, string? email, string? senha, byte[]? fotoPerfil) : base(id)
        {
            NomeUsuario = nomeUsuario;
            NomeCompleto = nomeCompleto;
            DataDeRegistro = dataDeRegistro;
            Email = email;
            Senha = senha;
            FotoPerfil = fotoPerfil;

        }

        public string? NomeUsuario { get; set; }
        public string? NomeCompleto { get; set; }
        public DateTime? DataDeRegistro { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public byte[]? FotoPerfil { get; set; }
    }
}
