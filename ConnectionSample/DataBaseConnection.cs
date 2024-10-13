using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnectionSample {

    //public class DatabaseConnection : IDisposable {

    //    private readonly string _connectionString;
    //    private SqlConnection _connection;

    //    public DatabaseConnection(string connectionString) {
    //        _connectionString = connectionString;
    //    }

    //    public SqlConnection GetConnection() {
    //        if (_connection == null || _connection.State != System.Data.ConnectionState.Open) {
    //            _connection = new SqlConnection(_connectionString);
    //            _connection.Open();
    //        }
    //        return _connection;
    //    }

    //    public void Dispose() {
    //        _connection?.Dispose();
    //    }
    //}

}
