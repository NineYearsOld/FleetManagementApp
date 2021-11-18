using BusinessLayer.Entities;
using BusinessLayer.Interfaces;
using BusinessLayer.Controllers;
using BusinessLayer.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services {
    public class BestuurderService {
        private IBestuurderRepository repo;

        public BestuurderService(IBestuurderRepository repo) {
            this.repo = repo;
        }

        public Bestuurder CreateBestuurder(string naam, string voornaam, DateTime geboorteDatum, string rijbewijs, string rijksregisternr) {
            try {
                BestuurderController bc = new BestuurderController();
                if (!string.IsNullOrWhiteSpace(naam) && !string.IsNullOrWhiteSpace(voornaam) && !string.IsNullOrWhiteSpace(rijbewijs) && BestuurderController.ValidatieRijkregisternummer(rijksregisternr)) {
                    if (!bc.BestuurdersLijst.ContainsKey(rijksregisternr)) {
                        Bestuurder b = new Bestuurder(naam, voornaam, geboorteDatum, rijksregisternr, rijbewijs);
                        // DB Create
                        // Id uit db invullen
                        bc.BestuurdersLijst.Add(rijksregisternr, b);
                        repo.CreateBestuurder(b);
                        return b;
                    } else {

                    }
                } else {
                    throw new BestuurderException("Een verplicht veld is leeg.");
                }
                return null;
            } catch (Exception) {

                throw;
            }
        }

        public void DeleteBestuurder(int id) {
            try {
                repo.DeleteBestuurder(id);
            } catch (Exception) {

                throw;
            }
        }

        public Bestuurder UpdateBestuurder(Bestuurder bestuurder) {
            try {
                repo.UpdateBestuurder(bestuurder);
                return bestuurder;
            } catch (Exception) {

                throw;
            }
        }

        public Bestuurder ToonDetails(int id) {
            try {
                return repo.ToonDetails(id);
            } catch (Exception) {

                throw;
            }
        }
    }
}
