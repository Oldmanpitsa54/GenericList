using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class Menu
    {
        public delegate void MenuErase(Menu menu);
        public event MenuErase RemoveFromMenu;

        public Menu()
        {
            Content = new List<Dish>
            {
                new Dish { Name = "Pitsa" },
                new Dish { Name = "Sushi" },
                new Dish { Name = "Burrito" },
                new Dish { Name = "Ramen" },
                new Dish { Name = "Borsh" }
        };

            ShitList = new List<Dish>();
        }

        public List<Dish> Content { get; set; }
        public List<Dish> ShitList { get; set; }

        public void Remove(Dish dish)
        {


            RemoveFromMenu?.Invoke(this);
            Content.Remove(dish);

        }
    }

}
