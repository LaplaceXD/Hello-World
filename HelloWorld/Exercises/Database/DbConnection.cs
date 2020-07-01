using System;

namespace HelloWorld.Exercises.Database
{
    public abstract class DbConnection
    {
        protected readonly DateTime _endTime;
        public string ConnectionString { get; private set; }
        public readonly TimeSpan _timeOut;

        protected DbConnection (string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException("Can't pass null as an argument.");

            this._endTime = DateTime.Now.AddMinutes(3);
            this.ConnectionString = connectionString;
            this._timeOut = TimeSpan.FromMinutes(3);
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}