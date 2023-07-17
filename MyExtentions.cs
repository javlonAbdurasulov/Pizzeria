using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pizzeria
{
    public static class MyExtentions
    {
        public static List<Bakers> addBakers(this List<Bakers> bakers,string name, long id, int experience)
        {
            bakers.Add(new Bakers(name,id, experience));
            return bakers;
        }
        public static List<Couriers> addCouriers(this List<Couriers> couriers,string name, long id, int basket)
        {
            couriers.Add(new Couriers(name,id, basket));
            return couriers;
        }
    }
}
