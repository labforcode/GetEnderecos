using GetEnderecos.Domain.Entities.Enderecos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GetEnderecos.Infra.Data.Maps.Enderecos
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("enderecos");
            builder.HasKey(c => c.Cep);

            builder.Property(c => c.Cep)
                   .HasColumnName("cep")
                   .HasColumnType("varchar(8)")
                   .IsRequired();

            builder.Property(c => c.Logradouro)
                   .HasColumnName("logradouro")
                   .HasColumnType("varchar(250)")
                   .IsRequired();

            builder.Property(c => c.Complemento)
                    .HasColumnName("complemento")
                    .HasColumnType("varchar(150)")
                    .IsRequired();

            builder.Property(c => c.Bairro)
                   .HasColumnName("bairro")
                   .HasColumnType("varchar(100)")
                   .IsRequired();

            builder.Property(c => c.Municipio)
                   .HasColumnName("municipio")
                   .HasColumnType("varchar(100)")
                   .IsRequired();

            builder.Property(c => c.IbgeMunicipio)
                   .HasColumnName("ibge_municipio")
                   .HasColumnType("varchar(10)")
                   .IsRequired();

            builder.Property(c => c.Uf)
                   .HasColumnName("uf")
                   .HasColumnType("varchar(2)")
                   .IsRequired();

            builder.Property(c => c.IbgeUf)
                   .HasColumnName("ibge_uf")
                   .HasColumnType("varchar(2)")
                   .IsRequired();
        }
    }
}
