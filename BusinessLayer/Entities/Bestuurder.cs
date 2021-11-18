using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Exceptions;
using BusinessLayer.Controllers;

namespace BusinessLayer.Entities {
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


        // Update functies hier om private setters te houden
        public void UpdateNaam(string naam) {
            if (!string.IsNullOrWhiteSpace(naam) && Naam != naam) {
                Naam = naam;
            } else {
                throw new BestuurderException(""); // Message nog in te vullen
            }
        }

        public void UpdateVoornaam(string voornaam) {
            if (!string.IsNullOrWhiteSpace(voornaam) && Voornaam != voornaam) {
                Voornaam = voornaam;
            } else {
                throw new BestuurderException(""); // Message nog in te vullen
            }
        }

        public void UpdatePostcode(int postcode) {
            if (Postcode != postcode) {
                Postcode = postcode;
            } else {
                throw new BestuurderException(""); // Message nog in te vullen
            }
        }

        public void UpdateGemeente(string gemeente) {
            if (Gemeente != gemeente) {
                Gemeente = gemeente;
            } else {
                throw new BestuurderException(""); // Message nog in te vullen
            }
        }

        public void UpdateStraat(string straat) {
            if (Straat != straat) {
                Straat = straat;
            } else {
                throw new BestuurderException(""); // Message nog in te vullen
            }
        }

        public void UpdateHuisnummer(string huisnummer) {
            if (Huisnummer != huisnummer) {
                Huisnummer = huisnummer;
            } else {
                throw new BestuurderException(""); // Message nog in te vullen
            }
        }

        public void UpdateRijksregisternummer(string rijksregisternummer) {
            if (!string.IsNullOrWhiteSpace(rijksregisternummer) && RijksregisterNummer != rijksregisternummer && BestuurderController.ValidatieRijkregisternummer(rijksregisternummer)) {
                RijksregisterNummer = rijksregisternummer;
            } else {
                throw new BestuurderException(""); // Message nog in te vullen
            }
        }

        public void UpdateRijbewijs(List<string> rijbewijs) {
            if (rijbewijs.Count != 0) {

            } else {
                throw new BestuurderException(""); // Message nog in te vullen
            }
        }

        public void UpdateVoertuig(Voertuig voertuig) {
            if (true) {

            } else {
                throw new BestuurderException(""); // Message nog in te vullen
            }
        }

        public void UpdateTankkaart(Tankkaart tankkaart) {
            if (true) {

            } else {
                throw new BestuurderException(""); // Message nog in te vullen
            }
        }
    }
}
