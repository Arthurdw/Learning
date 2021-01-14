using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;

namespace Blobs
{
    public class BlobsImage
    {
        public string Name;
        public Image Img;

        public BlobsImage(string name, byte[] bytes)
        {
            this.Name = name;
            this.Img = this.BytesToImage(bytes);
        }

        private Image BytesToImage(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
    }

    public class DataHandler
    {
        public MySqlConnection Connection { get; }
        private string ConnectionString { get; }

        public DataHandler(string userName, string password, string database, string ip, string port)
        {
            ConnectionString =
                $"Server={ip};Port={port};SslMode=none;Database={database};Uid={userName};Pwd={password}";
            Connection = new MySqlConnection(ConnectionString);
        }

        public void Execute(string name, byte[] data)
        {
            Connection.Open();
            MySqlCommand cmd = new MySqlCommand(SqlStatementsDataset.AddBlob, Connection);
            // cmd.Parameters.Add(new MySqlParameter("@name", MySqlDbType.VarChar, name.Length));
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@data", data);
            int changed = cmd.ExecuteNonQuery();
            Connection.Close();

            if (changed == 0)
                throw new InvalidExecuteException("No rows got changed");
        }

        private BlobsImage GetBlobsImage(MySqlCommand cmd)
        {
            BlobsImage returnValue = null;

            Connection.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                returnValue = new BlobsImage((string)rdr[0], (byte[])rdr[1]);
                break;
            }

            rdr.Close();
            Connection.Close();

            Console.WriteLine($@"Successfully fetched image: {returnValue?.Name}");

            return returnValue;
        }

        public BlobsImage GetLatestBlobsImage()
        {
            MySqlCommand cmd = new MySqlCommand(SqlStatementsDataset.GetLatestBlob, Connection);
            return GetBlobsImage(cmd);
        }

        public BlobsImage GetSpecificBlobsImage(string name)
        {
            MySqlCommand cmd = new MySqlCommand(SqlStatementsDataset.GetSpecificImage, Connection);
            cmd.Parameters.AddWithValue(@"@name", name);

            return GetBlobsImage(cmd);
        }
    }

    // Kwou eens met custom errors leren werken :)
    [Serializable]
    internal class InvalidExecuteException : Exception
    {
        public new string Message = "An invalid sql statement got executed.";

        public InvalidExecuteException()
        {
        }

        public InvalidExecuteException(string message) : base(message)
        {
            this.Message = message;
        }
    }
}