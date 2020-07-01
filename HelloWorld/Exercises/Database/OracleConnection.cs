using System;

namespace HelloWorld.Exercises.Database
{
    public class OracleConnection : DbConnection
    {
        public bool HasOpenedConnection { get; private set; }
        public OracleConnection (string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            if(HasOpenedConnection)
                throw new InvalidOperationException("There is already an open connection, please close it to open another one.");

            if (_endTime - DateTime.Now <= TimeSpan.Zero)
                throw new Exception("System timed out.");

            HasOpenedConnection = true;
            Console.WriteLine("Oracle Connection has been opened.");
        }

        public override void CloseConnection()
        {
            if(!HasOpenedConnection)
                throw new InvalidOperationException("Can't close a connection, when there is no connection.");

            HasOpenedConnection = false;
            Console.WriteLine("Oracle Connection has been closed.");
        }
    }
}