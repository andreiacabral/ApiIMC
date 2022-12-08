using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class ConsultaIMCMap : IEntityTypeConfiguration<ConsultaIMC>
    {
        public void Configure(EntityTypeBuilder<ConsultaIMC> builder)
        {
            builder.ToTable("Consulta");

            builder.HasKey(x => x.ConsultaId);

            builder.Property(u => u.NomePaciente)
               .HasMaxLength(60);

            builder.Property(u => u.EnderecoCompleto)
               .HasMaxLength(60);

            builder.Property(u => u.Altura);

            builder.Property(u => u.Pesokg);
           
            builder.Property(u => u.Resultado);

        }
    }
}
