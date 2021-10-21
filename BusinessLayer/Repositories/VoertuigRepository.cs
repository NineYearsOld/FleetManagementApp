using Bussiness_Layer.Entities;
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


        public void CreateVoertuig() {

        }

        public void DeleteVoertuig(string chassisnummer) {
            if (VoertuigLijst.ContainsKey(chassisnummer)) {
                VoertuigLijst.Remove(chassisnummer);
            } else {

            }
        }

        public void UpdateVoertuig() {

        }

        public Voertuig ToonDetails() {

        }
    }
}
