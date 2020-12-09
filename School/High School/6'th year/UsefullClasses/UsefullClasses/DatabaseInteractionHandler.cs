using MySql.Data.MySqlClient;
using System;

namespace UsefullClasses
{
    [Serializable]
    internal class UnableToConnectException : Exception
    {
        public string Message { get; }

        public UnableToConnectException(string connectionMessage) : base($"Can not connect to database. Connection string: {connectionMessage}")
        {
            Message = connectionMessage;
        }
    }

    internal class DatabaseInteractionHandler
    {
        public MySqlConnection Connection { get; }
        public MySqlDataAdapter Adapter { get; }

        public string ConnectionString { get; }

        public DatabaseInteractionHandler(string userName, string password, string database, string ip, string port)
        {
            ConnectionString =
                $"Server={ip};Port={port};SslMode=none;Database={database};Uid={userName};Pwd={password}";
            Connection = new MySqlConnection(ConnectionString);
            TestConnection();
        }

        public void TestConnection()
        {
            try
            {
                Connection.Open();
                Connection.Close();
            }
            catch (MySqlException)
            {
                throw new UnableToConnectException(ConnectionString);
            }
        }
    }
}