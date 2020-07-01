using System;

namespace HelloWorld.Exercises.Database
{
    public class DbCommand
    {
        private readonly string _instruction;
        private readonly string _connectionType;
        public DbCommand(DbConnection connection, string instruction)
        {
            if(connection == null)
                throw new ArgumentNullException("Connection can't be null.");
            if(string.IsNullOrEmpty(instruction))
                throw new ArgumentNullException("Instruction can't be null");

            _instruction = instruction;
            _connectionType = connection.ToString();

            if (connection is SqlConnection)
            {
                var sqlConnection = (SqlConnection) connection;
                if(sqlConnection.HasOpenedConnection)
                    Console.WriteLine("Converting instruction \"{0}\" to T-SQL format...", instruction);
                else
                    throw new Exception("There is no open Sql Connection.");
            }
            else if (connection is OracleConnection)
            {
                var oracleConnection = (OracleConnection) connection;
                if(oracleConnection.HasOpenedConnection)
                    Console.WriteLine("Converting instruction \"{0}\" to Oracle format...", instruction);
                else
                    throw new Exception("There is no open Oracle Connection.");
            }
            else
                throw new Exception("There is no open connection");                
        }

        public void Execute()
        {
            Console.WriteLine("Currently executing {0} instruction: " + _instruction, _connectionType);
        }
    }
}