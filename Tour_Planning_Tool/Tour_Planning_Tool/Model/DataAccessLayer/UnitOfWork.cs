using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour_Planning_Tool.Model.DataAccessLayer.Repositories;

namespace Tour_Planning_Tool.Model.DataAccessLayer
{
    public class UnitOfWork
    {

        private readonly string connString;
        private readonly NpgsqlConnection npgsqlConnection;
        private bool disposedValue;
        private NpgsqlTransaction? sqlTran;



        #region Repository Declarations

        private TourRepository? tourRepository = null;


        #endregion

        #region RepositoryGetters
        public TourRepository TourRepository()
        {
            if (tourRepository == null)
            {
                tourRepository = new TourRepository(npgsqlConnection);
            }
            return tourRepository;
        }
        #endregion


        public UnitOfWork()
        {
            var mapper = MainWindow.GetConfigMapper();
            if (mapper == null) throw new NullReferenceException();

            connString = mapper.ConnectionString;

            npgsqlConnection = new NpgsqlConnection(connString);
            npgsqlConnection.Open();
            CreateTransaction();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (sqlTran != null)
                    {
                        Commit();
                    }
                    npgsqlConnection?.Close();
                    npgsqlConnection?.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public void CreateTransaction()
        {
            //Log.Information("Transaction started");
            sqlTran = npgsqlConnection.BeginTransaction();
        }

        public void Commit()
        {
            //Log.Information("Commited changes");
            sqlTran?.Commit();
        }

        public void Rollback()
        {
            //Log.Information("Rollback started");
            sqlTran?.Rollback();
            sqlTran = null;
        }
    }
}
