using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace_2022.Shared {
    public class HardCodedMenuService : IMenuService {
        public ValueTask<Menu> GetMenu() => new ValueTask<Menu>(
            new Menu {
                Pizzas = new List<Pizza> {
                    //new Pizza(1, "Pepperoni", 8.99M, Spiciness.Spicy),
                    //new Pizza(2, "Margarita", 7.99M, Spiciness.None),
                    ////new Pizza(3, "Diabolo", 9.99M, Spiciness.Hot)
                   new Pizza(4, "Hoa xương rồng", 45, Spiciness.hoa1),

                    new Pizza(5, "Hoa Móng Rồng", 50, Spiciness.hoa2),
                     new Pizza(6, "Hoa Tai Thỏ", 60, Spiciness.hoa3),
                      new Pizza(7, "Hoa Hồng", 49, Spiciness.hoa4)
                }
            });
    }
}

