using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Layer.Entities {
    public class Bestuurder {
        public Bestuurder(string naam, string voornaam, DateTime geboorteDatum, string rijksregisterNummer, string rijbewijs) {
            Naam = naam;
            Voornaam = voornaam;
            GeboorteDatum = geboorteDatum;
            RijksregisterNummer = rijksregisterNummer;
            Rijbewijs = rijbewijs;
        }

        public int Id { get; private set; }
        public string Naam { get; private set; }
        public string Voornaam { get; private set; }
        public int? Postcode { get; private set; }
        public string Gemeente { get; private set; }
        public string Straat { get; private set; }
        public string Huisnummer { get; private set; }
        public DateTime GeboorteDatum { get; private set; }
        public string RijksregisterNummer { get; private set; }
        public string Rijbewijs { get; private set; }
        public Voertuig Voertuig { get; private set; }
        public Tankkaart Tankkaart { get; private set; }

        public void Update(string naam, string voornaam, int? postcode, string? gemeente, string? straat, string? huisnummer, string rijkregisternummer, string rijbewijs, Voertuig? voertuig, Tankkaart? tankkaart) {
            if (naam != null && voornaam != null && rijkregisternummer != null && rijbewijs != null) { // UNF
                Naam = naam;
                Voornaam = voornaam;
                RijksregisterNummer = rijkregisternummer;
                Rijbewijs = rijbewijs;
            } else { }
            Postcode = postcode;
            Gemeente = gemeente;
            Straat = straat;
            Huisnummer = huisnummer;
            Voertuig = voertuig;
            Tankkaart = tankkaart;
        }
    }
}
