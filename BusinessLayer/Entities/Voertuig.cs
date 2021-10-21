using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness_Layer.Enums;

namespace Bussiness_Layer.Entities {
    public class Voertuig {
        public Voertuig(string merk, string model, string chassisNummer, string nummerplaat, Brandstoffen brandstof, string typeWagen)
        {
            Merk = merk;
            Model = model;
            ChassisNummer = chassisNummer;
            Nummerplaat = nummerplaat;
            Brandstof = brandstof;
            TypeWagen = typeWagen;           
        }

        public string Merk { get; private set; }
        public string Model { get; private set; }
        public string ChassisNummer { get; private set; }
        public string Nummerplaat { get; private set; }
        public Brandstoffen Brandstof { get; private set; }
        public string TypeWagen { get; private set; }
        public string Kleur { get; private set; }
        public int AantalDeuren { get; private set; }
        public Bestuurder Bestuurder { get; private set; }
    }
}
