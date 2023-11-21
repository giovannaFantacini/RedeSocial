namespace RedeSocial.App.Model
{
    public class UsuarioModel
    {
    
        public string? NomeUsuario { get; set; }
        public string? NomeCompleto { get; set; }
        public DateTime DataDeRegistro { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public byte[]? FotoPerfil { get; set; }
    }
}
