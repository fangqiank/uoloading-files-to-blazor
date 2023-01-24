using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace UploadFilesLib
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task SaveData(string storeProc, string connection, object parameters)
        {
            string connString = _config.GetConnectionString(connection)
                ?? throw new Exception($"Missing connection string at ${connection}");

            using var conn = new SqlConnection(connString);

            await conn.ExecuteAsync(
                storeProc,
                parameters,
                commandType: System.Data.CommandType.StoredProcedure
            );

        }
    }
}
