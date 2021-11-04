using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Exceptions;
using BussinessLayer.Controllers;

namespace BussinessLayer.Entities {
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
            if (naam != null && Naam != naam) {
                Naam = naam;
            } else {
                
            }
        }

        public void UpdateVoornaam(string voornaam) {
            if (voornaam != null && Voornaam != voornaam) {
                Voornaam = voornaam;
            } else {

            }
        }

        public void UpdatePostcode(int postcode) {
            if (Postcode != postcode) {
                Postcode = postcode;
            } else {

            }
        }

        public void UpdateGemeente(string gemeente) {
            if (Gemeente != gemeente) {
                Gemeente = gemeente;
            } else {

            }
        }

        public void UpdateStraat(string straat) {
            if (Straat != straat) {
                Straat = straat;
            } else {

            }
        }

        public void UpdateHuisnummer(string huisnummer) {
            if (Huisnummer != huisnummer) {
                Huisnummer = huisnummer;
            } else {

            }
        }

        public void UpdateRijksregisternummer(string rijksregisternummer) {
            if (rijksregisternummer != null && RijksregisterNummer != rijksregisternummer && BestuurderController.ValidatieRijkregisternummer(rijksregisternummer)) {
                RijksregisterNummer = rijksregisternummer;
            } else {

            }
        }

        public void UpdateRijbewijs() {
            if (true) {

            } else {

            }
        }

        public void UpdateVoertuig(Voertuig voertuig) {
            if (true) {

            } else {

            }
        }

        public void UpdateTankkaart(Tankkaart tankkaart) {
            if (true) {

            } else {

            }
        }
    }
}
