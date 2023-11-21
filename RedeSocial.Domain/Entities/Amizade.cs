using RedeSocial.Domain.Base;

namespace RedeSocial.Domain.Entities
{
    public class Amizade : BaseEntity<int>
    {
        public Amizade()
        {

        }

        public Amizade(int id, Usuario? usuario1, Usuario? usuario2, string? estadoAmizade) : base(id)
        {
            Usuario1 = usuario1;
            Usuario2 = usuario2;
            EstadoAmizade = estadoAmizade;
        }

        public Usuario? Usuario1 { get; set; }
        public Usuario? Usuario2 { get; set; }
        public string? EstadoAmizade { get; set; }
    }
}
