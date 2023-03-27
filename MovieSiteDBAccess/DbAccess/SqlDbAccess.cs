using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace MovieSiteData.DbAccess
{
    public class SqlDbAccess:ISqlDbAccess
    {
        private readonly IConfiguration _config;

        public SqlDbAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IEnumerable<T>> GetDataFromSql<T, TU>(string storedProcedure, TU parameter, string connectionId="Default")
        {
            using IDbConnection sql = new SqlConnection(_config.GetConnectionString(connectionId));
            return await sql.QueryAsync<T>(storedProcedure, parameter, commandType: CommandType.StoredProcedure);
        }

        public async Task SendDataToSql<T>(string storedProcedure, T parameter, string connectionId = "Default")
        {
            using IDbConnection sql = new SqlConnection(_config.GetConnectionString(connectionId));
            await sql.ExecuteAsync(storedProcedure, parameter, commandType: CommandType.StoredProcedure);
        }
    }
}
