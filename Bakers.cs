using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class Bakers:Person
    {
        public Bakers()
        {
            
        }
        public Bakers(string name, long id, int experience)
        {
            Name = name;
            Id = id;
            Experience = experience;
        }
        public int Experience{ get; set; }


        public static List<Bakers> GetBakers()
        {
            List<Bakers> list = new()
            {
                new Bakers { Name = "Javlon" , Id = 998975578475, Experience = 1 },
                new Bakers { Name = "Shokir" , Id = 998931234567, Experience = 1 },
                new Bakers { Name = "Miraziz" , Id = 998991234567, Experience = 2 },
                new Bakers { Name = "Mehroj" , Id = 998941234567, Experience = 3 },
            };
            return list;
        }

    }
}
