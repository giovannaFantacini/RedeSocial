using RedeSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RedeSocial.Repository.Mappings
{
    public class PostagemMap : IEntityTypeConfiguration<Postagem>
    {
        public void Configure(EntityTypeBuilder<Postagem> builder)
        {
            builder.ToTable("Postagem");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.TextoDaPostagem)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.Property(prop => prop.DataHoraPostagem)
                .IsRequired()
                .HasColumnType("datetime");

            builder.HasOne(prop => prop.Usuario);
        }
    }
}
