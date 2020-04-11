using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Data;

namespace GetEnderecos.Infra.Data.Repositories.Dapper
{
    public class RepositoryBaseDapper : IDisposable
    {
        private readonly string _connectionString;

        public RepositoryBaseDapper(IConfiguration configuration)
        {
            _connectionString = configuration.GetValue<string>("ConnectionStrings:dbenderecos");
        }

        public IDbConnection Connection => new NpgsqlConnection(_connectionString);

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
