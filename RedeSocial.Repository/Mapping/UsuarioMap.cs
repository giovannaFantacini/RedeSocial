using RedeSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RedeSocial.Repository.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.NomeUsuario)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.NomeCompleto)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.DataDeRegistro)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Senha)
                .IsRequired()
                .HasColumnType("varchar(8)");

            builder.Property(prop => prop.FotoPerfil)
                .HasColumnType("varbinary(max)");
        }
    }
}
