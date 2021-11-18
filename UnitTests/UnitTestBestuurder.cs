using BusinessLayer.Exceptions;
using BusinessLayer.Controllers;
using BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTests {
    public class UnitTestBestuurder {
        [Fact]
        public void TestValidatieRijksregister() {
            string rijksregister = "12345678912";
            string rijksregister2 = "12345678958";

            Assert.False(BestuurderController.ValidatieRijkregisternummer(rijksregister));
            Assert.True(BestuurderController.ValidatieRijkregisternummer(rijksregister2));
            
            var ex = Assert.Throws<BestuurderException>(() => BestuurderController.ValidatieRijkregisternummer(rijksregister));

            Assert.Equal("Rijksregisternummer ongeldig", ex.Message);

            //Aangezien exceptions worden opgevangen werkt dit niet.
            
        }

        [Fact]
        public void TestCreateBestuurder() {
            string naam = "Bezos";
            string naam2 = "";
            string voornaam = "Jef";
            string voornaam2 = null;
            DateTime geboortedatum = new DateTime(1990,8,24);
            string rijksregister = "12345678958";
            // List<string> rijbewijs = new List<string>();
            string rijbewijs = "";

            BestuurderController bc = new BestuurderController();

            /*
            var ex = Assert.Throws<BestuurderException>(()=>bc.CreateBestuurder(naam,voornaam,geboortedatum,rijksregister,rijbewijs));
            Assert.Equal("Een verplicht veld is leeg.", ex.Message);
            */

            // lege list rijbewijs
            bc.CreateBestuurder(naam, voornaam, geboortedatum, rijksregister, rijbewijs);
            Assert.Empty(bc.BestuurdersLijst);

            // lege naam
            rijbewijs = "B";
            bc.CreateBestuurder(naam2, voornaam, geboortedatum, rijksregister, rijbewijs);
            Assert.Empty(bc.BestuurdersLijst);

            // voornaam = null
            bc.CreateBestuurder(naam, voornaam2, geboortedatum, rijksregister, rijbewijs);
            Assert.Empty(bc.BestuurdersLijst);

            // correcte invoer
            bc.CreateBestuurder(naam, voornaam, geboortedatum, rijksregister, rijbewijs);
            Assert.Single(bc.BestuurdersLijst);
        }
    }
}
