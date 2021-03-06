using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness_Layer.Enums;

namespace Bussiness_Layer.Entities {
    public class Voertuig {
        public Voertuig(string merk, string model, string chassisNummer, string nummerplaat, List<Brandstoffen> brandstoffen, WagenTypes typeWagen)
        {
            Merk = merk;
            Model = model;
            ChassisNummer = chassisNummer;
            Nummerplaat = nummerplaat;
            Brandstoffen = brandstoffen;
            TypeWagen = typeWagen;           
        }

        public string Merk { get; private set; }
        public string Model { get; private set; }
        public string ChassisNummer { get; private set; }
        public string Nummerplaat { get; private set; }
        public List<Brandstoffen> Brandstoffen { get; private set; }
        public WagenTypes TypeWagen { get; private set; }
        public string Kleur { get; private set; }
        public int AantalDeuren { get; private set; }
        public Bestuurder Bestuurder { get; private set; }
    }
}
