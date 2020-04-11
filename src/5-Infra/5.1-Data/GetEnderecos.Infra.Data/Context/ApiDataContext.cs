using GetEnderecos.Domain.Entities.Enderecos;
using GetEnderecos.Infra.Data.Maps.Enderecos;
using Microsoft.EntityFrameworkCore;

namespace GetEnderecos.Infra.Data.Context
{
    public class ApiDataContext : DbContext
    {
        #region DbSet
        public DbSet<Endereco> Enderecos { get; set; }

        #endregion

        public ApiDataContext(DbContextOptions<ApiDataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("public");
            builder.ApplyConfiguration(new EnderecoMap());
        }
    }
}
