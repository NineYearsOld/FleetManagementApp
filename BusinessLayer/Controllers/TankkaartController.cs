using Bussiness_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Controllers {
    public class TankkaartController {
        public TankkaartController() {
            TankkaartLijst = new Dictionary<int, Tankkaart>();
        }

        public Dictionary<int, Tankkaart> TankkaartLijst { get; private set; }

        public void CreateTankkaart(int kaartnummer, DateTime geldigheidsdatum) {
            if (!TankkaartLijst.ContainsKey(kaartnummer)) { // Kaartnummer moet uniek zijn
                Tankkaart tk = new Tankkaart(kaartnummer, geldigheidsdatum);
                // DB Create
                TankkaartLijst.Add(kaartnummer, tk);
            } else {

            }
        }

        public void DeleteTankkaart(int kaartnummer) {
            if (TankkaartLijst.ContainsKey(kaartnummer)) {
                // DB Delete
                TankkaartLijst.Remove(kaartnummer);
            } else {

            }
        }

        public void UpdateTankkaart() { // Nog uit te werken

        }

        public Tankkaart ToonDetails(int kaartnummer) {
            if (TankkaartLijst.ContainsKey(kaartnummer)) {
                return TankkaartLijst[kaartnummer];
            } else {
                return null;
            }
        }
    }
}

