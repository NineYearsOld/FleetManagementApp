using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness_Layer.Entities;

namespace Bussiness_Layer.Controllers {
    public class BestuurderController {
        public BestuurderController() {
            BestuurdersLijst = new Dictionary<string, Bestuurder>();
        }


        public Dictionary<string, Bestuurder> BestuurdersLijst { get; private set; }


        public void CreateBestuurder(string naam, string voornaam, DateTime geboorteDatum, string rijksregisternr, string rijbewijs) {
            if (naam != null && voornaam != null && rijbewijs != null && ValidatieRijkregisternummer(rijksregisternr)) {

                if (!BestuurdersLijst.ContainsKey(rijksregisternr)) {
                    Bestuurder b = new Bestuurder(naam, voornaam, geboorteDatum, rijksregisternr, rijbewijs);
                    // DB Create
                    // Id uit db invullen
                    BestuurdersLijst.Add(rijksregisternr, b);
                } else { }
            } else {

            }
        }

        public static bool ValidatieRijkregisternummer(string rijksregisternr) { // Zou correct moeten zijn
            if (rijksregisternr == null) {
                return false;
            } else if (rijksregisternr.Length != 11) {
                return false;
            } else {
                int laatste2 = int.Parse(rijksregisternr.Substring(9));
                int eerste9 = int.Parse(rijksregisternr.Substring(0, 8));
                if (laatste2 == 97 - (eerste9 % 97)) {
                    return true;
                } else {
                    return false;
                }
            }
        }

        public  void DeleteBestuurder(Bestuurder bestuurder)
        {
            if(bestuurder != null)
            {
                // DB Delete
                BestuurdersLijst.Remove(bestuurder.RijksregisterNummer);
            }
        }

        public void UpdateBestuurder(Bestuurder bestuurder)
        {
            if(bestuurder != null)
            {
                BestuurdersLijst[bestuurder.RijksregisterNummer] = bestuurder;
            }
        }

        public Bestuurder ToonDetails(string bestuurderN)
        {
            Bestuurder bestuurder = (Bestuurder)BestuurdersLijst.Select(a => a.Value).Where(a=>a.RijksregisterNummer == bestuurderN);
            return bestuurder;
        }
    }
}
