using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class Menu
    {
        
        private string product{ get; set; }
        private decimal price{ get; set; }
        private Category category { get; set; }
        

        public static void GetMenu()
        {
            List<Menu> menu = new List<Menu>()
            {
                new Menu() { product = "Peperoni", price = 49000,category =Category.Pizza},
                new Menu() { product = "Sirniy", price = 45000,category =Category.Pizza},
                new Menu() { product = "Myasnoy", price = 60000,category =Category.Pizza},
                new Menu() { product = "4v1", price = 80000,category =Category.Pizza},
                new Menu() { product = "Cola 0.5L", price = 9000,category =Category.Drink},
                new Menu() { product = "Cola 1L", price = 12000,category =Category.Drink},
                new Menu() { product = "Cola 1.5L", price = 15000,category =Category.Drink},
            };
            foreach (var product in menu.GroupBy(p=>p.category))
            {
                Console.WriteLine(product.Key+" :");
                foreach (var item in product)
                {
                Console.WriteLine($"\tName: {item.product}\tPrice: {item.price}");

                }
            }
        }
    }
    enum Category
    {
        Pizza,Drink
    }
}
