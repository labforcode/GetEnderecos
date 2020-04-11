using GetEnderecos.Domain.Entities.Enderecos;
using GetEnderecos.Domain.Interfaces.EF.Enderecos;
using GetEnderecos.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace GetEnderecos.Infra.Data.Repositories.EF.Enderecos
{
    public class EnderecoRepositoryEF : RepositoryBaseEF<Endereco>, IEnderecoRepositoryEF
    {
        private readonly ApiDataContext _context;
        private readonly DbSet<Endereco> _dbSet;

        public EnderecoRepositoryEF(ApiDataContext context) : base(context)
        {
            _context = context;
        }
    }
}
