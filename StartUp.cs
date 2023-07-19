using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    internal class StartUp
    {
        public static void Start() {
            List<Bakers> bakers = Bakers.GetBakers();
            List<Couriers> couriers = Couriers.GetCouriers();

            addBakers(bakers, "Sherzod", 998935555555, 4);

            Menu.GetMenu();

            




        }
        private static void addBakers(List<Bakers> bakers, string name, long id, int experience)
        {
            bakers.Add(new Bakers(name, id, experience));
        }
        private static void addCouriers(List<Couriers> couriers, string name, long id, int basket)
        {
            couriers.Add(new Couriers(name, id, basket));
        }
        public static int End() { return 0; }
    }
}
