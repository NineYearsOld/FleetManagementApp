using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Entities;
using BusinessLayer.Exceptions;

namespace BussinessLayer.Controllers {
    public class BestuurderController {
        public BestuurderController() {
            BestuurdersLijst = new Dictionary<string, Bestuurder>();
        }


        public Dictionary<string, Bestuurder> BestuurdersLijst { get; private set; }


        public void CreateBestuurder(string naam, string voornaam, DateTime geboorteDatum, string rijksregisternr, List<string> rijbewijs) {
            try {
                if (!string.IsNullOrWhiteSpace(naam) && !string.IsNullOrWhiteSpace(voornaam) && rijbewijs.Count != 0 && ValidatieRijkregisternummer(rijksregisternr)) {
                    if (!BestuurdersLijst.ContainsKey(rijksregisternr)) {
                        Bestuurder b = new Bestuurder(naam, voornaam, geboorteDatum, rijksregisternr, rijbewijs);
                        // DB Create
                        // Id uit db invullen
                        BestuurdersLijst.Add(rijksregisternr, b);
                    } else {

                    }
                } else {
                    throw new BestuurderException("Een verplicht veld is leeg.");
                }
            } catch {
                // Display exception
            }
        }

        public static bool ValidatieRijkregisternummer(string rijksregisternr) { // Zou correct moeten zijn.
            try {
                if (string.IsNullOrWhiteSpace(rijksregisternr)) {
                    throw new BestuurderException("Rijksregisternummer mag niet leeg zijn.");
                } else if (rijksregisternr.Length != 11) {
                    throw new BestuurderException("Rijksregisternummer moet uit 11 cijfers bestaan.");
                } else {
                    int laatste2 = int.Parse(rijksregisternr.Substring(9));
                    int eerste9 = int.Parse(rijksregisternr.Substring(0, 9));
                    if (laatste2 != (97 - (eerste9 % 97))) {
                        throw new BestuurderException("Rijksregisternummer ongeldig");
                    } else {
                        return true;
                    }
                }
            } catch {
                // Display exception
                return false;
            }
        }

        public void DeleteBestuurder(Bestuurder bestuurder) {
            if (bestuurder != null) {
                // DB Delete
                BestuurdersLijst.Remove(bestuurder.RijksregisterNummer);
            } else { }
        }

        public void UpdateBestuurder(Bestuurder bestuurder) {
            if (bestuurder != null) {
                BestuurdersLijst[bestuurder.RijksregisterNummer] = bestuurder;
            } else { }
        }

        public Bestuurder ToonDetails(string bestuurderN) {
            Bestuurder bestuurder = (Bestuurder)BestuurdersLijst.Select(a => a.Value).Where(a => a.RijksregisterNummer == bestuurderN);
            return bestuurder;
        }
    }
}
