using ListaTask.Shared;
using System.Data;
using System.Data.SqlClient;

namespace ListaTask.Infra.Data
{
    public class ListaTaskContext : IDataContext
    {
        private readonly SqlConnection _connection;
        private SqlTransaction _transaction;

        public ListaTaskContext()
        {
            _connection = new SqlConnection(Settings.ConnectionString);
            _connection.Open();
        }

        public SqlConnection Connection => _connection;

        public void BeginTransaction()
        {
            _transaction = _connection.BeginTransaction();
        }


        public void Commit()
        {
            if (_transaction != null)
                _transaction.Commit();
        }

        public void Rollback()
        {
            if (_transaction != null)
                _transaction.Rollback();
        }

        public void Dispose()
        {
            if (_connection.State != ConnectionState.Closed)
                _connection.Close();
        }
    }
}
