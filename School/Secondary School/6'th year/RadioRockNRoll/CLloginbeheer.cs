using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioRockNRoll
{
    class CLloginbeheer
    {
        private string username;
        private string password;
        private CLdatabeheer db;

        public List<DataStructure> users { get; private set; }

        public CLloginbeheer(CLdatabeheer db, string username, string password)
        {
            this.username = username;
            this.password = password;
            this.db = db;
        }

        public bool IsValidLogin()
        {
            // string[] scrambleValues = new[] {"$át", "@éerx", "yç£", "K°LO&", "_!P", "tMá#"};

            // string[] hashedPaswoorden = new string[scrambleValues.Length];

            // for (int i = 0; i < scrambleValues.Length; i++)
            // {
            //     CLhashbeheer hb = new CLhashbeheer(passwoord, i, scrambleValues);
            //     hb.GenerateHashSha512();
            //     hashedPaswoorden[i] = hb.HashedValue;
            //     Console.WriteLine($"Hash: {hb.HashedValue}");
            // }

            // We moeten elke veld er specifiek in zetten om zeker te weten dat de volgorde van de query klopt.
            string sql = "SELECT userid, voornaam, naam, gebruiksrecht, userName, origineel, pwhashed " +
                         "FROM users " +
                         $"WHERE userName = '{this.username}' " +
                         $"AND origineel = '{this.password}'";
            // $"AND pwhashed IN ({String.Join(", ", hashedPaswoorden)}) ;";

            this.users = db.GetUsers(sql);

            return this.users.Count != 0;
        }
    }
}
