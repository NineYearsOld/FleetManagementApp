using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Enums;

namespace BusinessLayer.Entities {
    public class Tankkaart {
        public Tankkaart(int kaartNummer, DateTime geldigheidsDatum) {
            KaartNummer = kaartNummer;
            GeldigheidsDatum = geldigheidsDatum;
        }

        public int KaartNummer { get; private set; }
        public DateTime GeldigheidsDatum { get; private set; }
        public int Pincode { get; private set; }
        public List<Brandstoffen> Brandstoffen { get; private set; }
        public Bestuurder Bestuurder { get; private set; }


    }
}
