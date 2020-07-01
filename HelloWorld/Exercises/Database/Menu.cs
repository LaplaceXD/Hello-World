using System;

namespace HelloWorld.Exercises.Database
{
    public class Menu
    {
        public Menu()
        {
            MainMenu();
        }
        private void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to DbConnection databases.");
            Console.WriteLine("To connect to preferred database please input its corresponding number.");
            Console.WriteLine();
            Console.WriteLine("1. SQL Database\n2. Oracle Database\n3. QUIT APPLICATION");
            var input = Console.ReadLine();

            if (input == "1")
                SqlMenu();
            else if (input == "2")
                OracleMenu();
            else if (input == "3")
                Console.WriteLine();
            else
                throw new InvalidOperationException("Input out of range.");

        }

        private void SqlMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the SQL Database.");
            Console.Write("To start input the ID of your database: ");
            var input = Console.ReadLine();

            Console.WriteLine("Processing...");
            Console.Clear();

            var connection = new SqlConnection(input);
            Console.WriteLine("Your connection to SQL database will timeout in {0} minutes, please open a connection by then.", connection._timeOut);
            Console.WriteLine();
            Console.WriteLine("To open a connection type 'open' in the console;\nTo close a connection type 'close';\nTo go back to the Main Menu type 'menu'");
            Console.WriteLine();
            var inputTwo = Console.ReadLine();

            if (inputTwo.ToLower() == "open")
            {
                Console.Clear();
                connection.OpenConnection();
                DatabaseMenu(connection);
            }
            else if(inputTwo.ToLower() == "close")
                connection.CloseConnection();
            else if (inputTwo.ToLower() == "menu")
                MainMenu();
            else
                throw new InvalidOperationException("Input out of range.");
        }

        private void OracleMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Oracle Database.");
            Console.Write("To start input the ID of your database: ");
            var input = Console.ReadLine();

            Console.WriteLine("Processing...");
            Console.Clear();

            var connection = new OracleConnection(input);
            Console.WriteLine("Your connection to Oracle database will timeout in {0} minutes, please open a connection by then.", connection._timeOut);
            Console.WriteLine();
            Console.WriteLine("To open a connection type 'open' in the console;\nTo close a connection type 'close';\nTo go back to the Main Menu type 'menu'");
            Console.WriteLine();
            var inputTwo = Console.ReadLine();

            if (inputTwo.ToLower() == "open")
            {
                Console.Clear();
                connection.OpenConnection();
                DatabaseMenu(connection);
            }
            else if (inputTwo.ToLower() == "close")
                connection.CloseConnection();
            else if (inputTwo.ToLower() == "menu")
                MainMenu();
            else
                throw new InvalidOperationException("Input out of range.");
        }

        private void DatabaseMenu(DbConnection connection)
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to execute a command? Type in 'yes' or 'no'.");
            var input = Console.ReadLine();

            if (input.ToLower() == "yes")
            {
                while (true)
                {
                    Console.Clear();
                    Console.Write("Input a command for the database: ");
                    
                    var commandInput = Console.ReadLine();
                    
                    Console.WriteLine();
                    
                    var command = new DbCommand(connection, commandInput);
                    
                    Console.WriteLine();
                    Console.WriteLine("Execute command? Type in 'yes' or 'no'.");
                    var executeInput = Console.ReadLine();

                    if (executeInput.ToLower() == "yes")
                    {
                        Console.Clear();
                        command.Execute();
                        Console.WriteLine("Execute another command? Type in 'yes' or 'no'.");
                        var anotherCommand = Console.ReadLine();
                        if (anotherCommand.ToLower() == "yes")
                            continue;
                        else if (anotherCommand.ToLower() == "no")
                            break;
                        else
                            throw new InvalidOperationException("Input out of range.");
                    }
                    else if (executeInput.ToLower() == "no")
                    {
                        Console.WriteLine("Input another command? Type in 'yes' or 'no'.");
                        var anotherCommand = Console.ReadLine();
                        if (anotherCommand.ToLower() == "yes")
                            continue;
                        else if (anotherCommand.ToLower() == "no")
                            break;
                        else
                            throw new InvalidOperationException("Input out of range.");
                    }
                    else
                        throw new InvalidOperationException("Input out of range.");
                }
                ClosingConnection(connection);
            }
            else if (input.ToLower() == "no")
            {
                ClosingConnection(connection);
            }
            else
                throw new InvalidOperationException("Input out of range.");
        }

        private void ClosingConnection(DbConnection connection)
        {
            Console.WriteLine();
            Console.WriteLine("Closing connection...");
            connection.CloseConnection();

            Console.WriteLine("Would you like to establish another connection? Type in 'yes' or 'no'.");
            var inputTwo = Console.ReadLine();
            if (inputTwo.ToLower() == "yes")
                MainMenu();
            else if (inputTwo.ToLower() == "no")
                Console.WriteLine();
            else
                throw new InvalidOperationException("Input out of range.");
        }
    }
}