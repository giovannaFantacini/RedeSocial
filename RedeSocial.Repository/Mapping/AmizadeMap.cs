using RedeSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RedeSocial.Repository.Mappings
{
    public class AmizadeMap : IEntityTypeConfiguration<Amizade>
    {
        public void Configure(EntityTypeBuilder<Amizade> builder)
        {
            builder.ToTable("Amizade");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.EstadoAmizade)
                .IsRequired()
                .HasColumnType("varchar(50)");


            builder.HasOne(prop => prop.Usuario1);


            builder.HasOne(prop => prop.Usuario2);
 
        }
    }
}
