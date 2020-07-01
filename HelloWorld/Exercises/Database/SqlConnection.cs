using System;

namespace HelloWorld.Exercises.Database
{
    public class SqlConnection : DbConnection
    {
        public bool HasOpenedConnection { get; private set; }
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            var initialization = DateTime.Now;
            if (HasOpenedConnection)
                throw new InvalidOperationException("There is already an open connection, please close it to open another one.");

            if(_endTime - initialization <= TimeSpan.Zero)
                throw new Exception("System timed out.");

            HasOpenedConnection = true;
            Console.WriteLine("Sql Connection has been opened.");
        }

        public override void CloseConnection()
        {
            if (!HasOpenedConnection)
                throw new InvalidOperationException("Can't close a connection, when there is no connection.");

            HasOpenedConnection = true;
            Console.WriteLine("Sql Connection has been closed.");
        }
    }
}