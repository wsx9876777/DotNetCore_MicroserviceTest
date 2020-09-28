using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Repository.Begonia.Db
{
    public class SqlConnectionBase : IDisposable
    {
        private SqlConnection _sqlConnection;
        public SqlConnection SqlConnection
        {
            get { return _sqlConnection; }
            set { _sqlConnection = value; }
        }

        private SqlTransaction _sqlTransaction;

        public SqlTransaction SqlTransaction
        {
            get { return _sqlTransaction; }
            set { _sqlTransaction = value; }
        }
        public SqlConnectionBase(string ConnStr)
        {
            _sqlConnection = new SqlConnection(ConnStr);
        }

        public void BegingSqlTransaction()
        {

            if (_sqlConnection != null)
            {
                if (_sqlConnection.State != ConnectionState.Open)
                {
                    _sqlConnection.Open();
                }
                _sqlTransaction = _sqlConnection.BeginTransaction();
            }
        }
        public void Open() => _sqlConnection.Open();
        public void Commit()=>_sqlTransaction.Commit();
        public void Rollback()=>_sqlTransaction.Rollback();
        public void Dispose()
        {
            _sqlConnection.Dispose();
        }
    }
}