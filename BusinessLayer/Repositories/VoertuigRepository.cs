﻿using Bussiness_Layer.Entities;
using Bussiness_Layer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Layer.Repositories {
    public class VoertuigRepository {
        public VoertuigRepository() {
            VoertuigLijst = new Dictionary<string, Voertuig>();
            Nummerplaten = new List<string>();
        }


        public Dictionary<string, Voertuig> VoertuigLijst { get; private set; }
        public List<string> Nummerplaten { get; private set; }


        public void CreateVoertuig(string merk, string model, string chassisNummer, string nummerplaat, Brandstoffen brandstof, string typeWagen) {
            if (VoertuigLijst.ContainsKey(chassisNummer)) { // Chassis nummer moet uniek zijn

            } else if (Nummerplaten.Contains(nummerplaat)) { // Nummerplaat moet uniek zijn

            } else {
                Voertuig v = new Voertuig(merk, model, chassisNummer, nummerplaat, brandstof, typeWagen);
                // DB Ceate
                VoertuigLijst.Add(chassisNummer, v);
                Nummerplaten.Add(nummerplaat);
            }
        }

        public void DeleteVoertuig(string chassisnummer) {
            if (VoertuigLijst.ContainsKey(chassisnummer)) {
                // DB Delete
                Nummerplaten.Remove(VoertuigLijst[chassisnummer].Nummerplaat);
                VoertuigLijst.Remove(chassisnummer);
            } else {

            }
        }

        public void UpdateVoertuig() { // Nog uit te werken

        }

        public Voertuig ToonDetails(string chassisnummer) {
            if (chassisnummer != null && VoertuigLijst.ContainsKey(chassisnummer)) {
                return VoertuigLijst[chassisnummer];
            } else {
                return null;
            }
        }
    }
}
