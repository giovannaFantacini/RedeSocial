using RedeSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RedeSocial.Repository.Mappings
{
    public class CurtidaMap : IEntityTypeConfiguration<Curtida>
    {
        public void Configure(EntityTypeBuilder<Curtida> builder)
        {
            builder.ToTable("Curtida");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.DataHoraCurtida)
                .IsRequired()
                .HasColumnType("datetime");


            builder.HasOne(prop => prop.Postagem);


            builder.HasOne(prop => prop.Usuario);

        }
    }
}
