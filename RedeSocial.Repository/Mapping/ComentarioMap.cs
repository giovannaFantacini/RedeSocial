using RedeSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RedeSocial.Repository.Mappings
{
    public class ComentarioMap : IEntityTypeConfiguration<Comentario>
    {
        public void Configure(EntityTypeBuilder<Comentario> builder)
        {
            builder.ToTable("Comentario");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.TextoComentario)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.Property(prop => prop.DataHoraComentario)
                .IsRequired()
                .HasColumnType("datetime");


            builder.HasOne(prop => prop.Postagem);


            builder.HasOne(prop => prop.Usuario);

        }
    }
}
