using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioRockNRoll
{
    public class Prijs
    {
        public int Id { get; private set; }
        public string Naam { get; private set; }
        public int Waarde { get; private set; }
        public int Startvoorraad { get; private set; }
        public int Voorraad { get; private set; }

        public Prijs(int id, string naam, int waarde, int startvoorraad, int voorraad)
        {
            Id = id;
            Naam = naam;
            Waarde = waarde;
            Startvoorraad = startvoorraad;
            Voorraad = voorraad;
        }
    }

    class CLprijsbeheer
    {
        private readonly CLdatabeheer _db;

        public Dictionary<int, Prijs> prijzen;

        private readonly Random _rn;

        public CLprijsbeheer(CLdatabeheer db)
        {
            this._db = db;
            prijzen = new Dictionary<int, Prijs>();
            _rn = new Random();
        }

        private Prijs KrijgRandomPrijs(List<Prijs> dbprijzen)
        {
            Prijs pr = dbprijzen[_rn.Next(0, dbprijzen.Count - 1)];
            return pr.Voorraad > 0 ? pr : KrijgRandomPrijs(dbprijzen);
        }

        public void GenereerPrijzen(int hoeveelheid = 10)
        {
            string sql = "SELECT IDPrijs, artikelnaam, waardePerStuk, Startvoorraad, ActueleVoorraad " +
                         "FROM prijzen ";

            List<Prijs> dbprijzen = _db.GetPrijzen(sql);

            prijzen = new Dictionary<int, Prijs>();

            for (int i = 0; i <= 10; i++)
            {
                Prijs prijs = KrijgRandomPrijs(dbprijzen);
                prijzen.Add(prijs.Id, prijs);
                dbprijzen.Remove(prijs);
            }

            int total = 0;

            foreach (KeyValuePair<int, Prijs> prijs in prijzen)
            {
                Console.WriteLine($@"{prijs.Key} - {prijs.Value.Waarde}");
                total += prijs.Value.Waarde;
            }

            Console.WriteLine(total);
        }
    }
}
