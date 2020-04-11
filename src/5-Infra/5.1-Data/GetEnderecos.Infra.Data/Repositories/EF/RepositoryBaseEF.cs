using GetEnderecos.Domain.Core.Interfaces.Repositories;
using GetEnderecos.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace GetEnderecos.Infra.Data.Repositories.EF
{
    public class RepositoryBaseEF<T> : IRepositoryBaseEF<T> where T : class
    {
        private readonly ApiDataContext _context;
        private readonly DbSet<T> _dbSet;
        public RepositoryBaseEF(ApiDataContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
    }
}
