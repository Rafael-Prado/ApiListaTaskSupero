using System;
using System.Data.SqlClient;

namespace ListaTask.Infra.Data
{
    public interface IDataContext : IDisposable
    {
        SqlConnection Connection { get; }
    }
}
