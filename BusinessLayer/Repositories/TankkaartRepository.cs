using Bussiness_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Layer.Repositories {
    public class TankkaartRepository {
        public TankkaartRepository() {
            TankkaartLijst = new Dictionary<int, Tankkaart>();
        }

        public Dictionary<int, Tankkaart> TankkaartLijst { get; private set; }

        public void CreateTankkaart(int kaartnummer, DateTime geldigheidsdatum) {
            if (!TankkaartLijst.ContainsKey(kaartnummer)) { 
            Tankkaart tk = new Tankkaart(kaartnummer, geldigheidsdatum);
            } else {

            }
        }

        public void DeleteTankkaart(int kaartnummer) {
            if (TankkaartLijst.ContainsKey(kaartnummer)) {
                TankkaartLijst.Remove(kaartnummer);
            } else {

            }
        }

        public void UpdateTankkaart() {

        }

        public Tankkaart ToonDetails(int kaartnummer) {

        }
    }
}

