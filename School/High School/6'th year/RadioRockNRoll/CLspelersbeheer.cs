using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioRockNRoll
{
    public class Speler
    {
        public string Gsm { get; private set; }
        public string Naam { get; private set; }
        public string Voornaam { get; private set; }

        public Speler(string gsm, string naam, string voornaam)
        {
            Gsm = gsm;
            Naam = naam;
            Voornaam = voornaam;
        }
    }

    public class CLspelersbeheer
    {
        private readonly Random _rn;
        public List<Speler> Spelers { get; private set; }

        public CLspelersbeheer(CLdatabeheer db)
        {
            string sql = "SELECT gsm, Naam, Voornaam " +
                         "FROM deelnemers";

            Spelers = db.GetSpelers(sql);
            _rn = new Random();
        }

        public Speler KrijgRandomSpeler() => Spelers[_rn.Next(0, Spelers.Count - 1)];
    }
}