using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace RadioRockNRoll
{
    public enum Rechten
    {
        Administrator,
        Gebruiker,
    }

    public class DataStructure
    {
        public string userid { get; private set; }
        public string voornaam { get; private set; }
        public string naam { get; private set; }
        public Rechten gebruikersrecht { get; private set; }
        public string username { get; private set; }

        private string _origineel { get; }
        private string _pwhashed { get; }

        public DataStructure(string userid, string voornaam, string naam, string gebruikersrecht, string userName,
            string origineel, string pwhashed)
        {
            this.userid = userid;
            this.voornaam = voornaam;
            this.naam = naam;
            switch (int.Parse(gebruikersrecht))
            {
                case 1:
                    this.gebruikersrecht = Rechten.Administrator;
                    break;
                default:
                    this.gebruikersrecht = Rechten.Gebruiker;
                    break;
            }
            this.username = userName;

            this._origineel = origineel;
            this._pwhashed = pwhashed;
        }
    }

    public class CLdatabeheer
    {
        // private const 
        public MySqlConnection Connection { get; }
        public MySqlDataAdapter Adapter { get; }

        private string ConnectionString { get; }
        public bool ConnectionStatus { get; private set; }

        public int StatementRowsChanged { get; private set; }

        public CLdatabeheer(string userName, string password, string database, string ip, string port)
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
                ConnectionStatus = true;
            }
            catch (MySqlException)
            {
                ConnectionStatus = false;
            }
        }

        public void Execute(string sql)
        {
            try
            {
                Connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, Connection);
                StatementRowsChanged = cmd.ExecuteNonQuery();
                Connection.Close();
                ConnectionStatus = true;
            }
            catch (MySqlException)
            {
                ConnectionStatus = false;
            }
        }

        public List<DataStructure> GetUsers(string sql)
        {
            List<DataStructure> collected = new List<DataStructure>();
            try
            {
                Connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, Connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr.FieldCount == 7)
                    {
                        collected.Add(new DataStructure(
                            rdr[0].ToString(), 
                            rdr[1].ToString(), 
                            rdr[2].ToString(), 
                            rdr[3].ToString(), 
                            rdr[4].ToString(), 
                            rdr[5].ToString(), 
                            rdr[6].ToString()));
                    }
                }
                rdr.Close();

                Connection.Close();
                ConnectionStatus = true;
                return collected;
            }
            catch (MySqlException)
            {
                ConnectionStatus = false;
                return collected;
            }
        }

        public List<Prijs> GetPrijzen(string sql)
        {
            List<Prijs> collected = new List<Prijs>();
            try
            {
                Connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, Connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr.FieldCount == 5)
                    {
                        collected.Add(new Prijs(
                            int.Parse(rdr[0].ToString()), 
                            rdr[1].ToString(), 
                            int.Parse(rdr[2].ToString()), 
                            int.Parse(rdr[3].ToString()), 
                            int.Parse(rdr[4].ToString())));
                    }
                }
                rdr.Close();

                Connection.Close();
                ConnectionStatus = true;
                return collected;
            }
            catch (MySqlException)
            {
                ConnectionStatus = false;
                return collected;
            }
        }
        public List<Speler> GetSpelers(string sql)
        {
            List<Speler> collected = new List<Speler>();
            try
            {
                Connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, Connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr.FieldCount == 3)
                    {
                        collected.Add(new Speler(
                            rdr[0].ToString(),
                            rdr[1].ToString(),
                            rdr[2].ToString()));
                    }
                }
                rdr.Close();

                Connection.Close();
                ConnectionStatus = true;
                return collected;
            }
            catch (MySqlException)
            {
                ConnectionStatus = false;
                return collected;
            }
        }
    }
}
