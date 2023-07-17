using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class Couriers:Person
    {
        public Couriers()
        {

        }
        public Couriers(string name, long id, int basket)
        {
            Name = name;
            Id = id;
            Basket = basket;
        }
        public int Basket{ get; set; }

        public static List<Couriers> GetCouriers()
        {
            List<Couriers> couriers = new List<Couriers>()
            {
                new Couriers() { Name = "Rustam", Id = 998997654321, Basket = 15},
                new Couriers() { Name = "Boisxon", Id = 998907654321, Basket = 10},
                new Couriers() { Name = "Daulet", Id = 998937654321, Basket = 8},
            };
            return couriers;
        }
        


    }
}
