using Bussiness_Layer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Layer.Entities {
    public class Tankkaart {
        public Tankkaart(int kaartNummer, DateTime geldigheidsDatum) {
            KaartNummer = kaartNummer;
            GeldigheidsDatum = geldigheidsDatum;
        }

        public int KaartNummer { get; private set; }
        public DateTime GeldigheidsDatum { get; private set; }
        public int Pincode { get; private set; }
        public Brandstoffen Brandstof { get; private set; }
        public Bestuurder Bestuurder { get; private set; }
    }
}
