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
    }
}

