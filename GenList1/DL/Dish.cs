using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class Dish
    {
        public string Name { get; set; }
        public void RemoveToTheShitList(Menu menu)
        {
            if (Name == "Sushi" && !menu.ShitList.Any(x => x.Name.Contains("Sushi")) || Name == "Ramen" && !menu.ShitList.Any(x => x.Name.Contains("Ramen")))
            {
                menu.ShitList.Add(this);
                Console.WriteLine($"OMG {Name}?!! hOW CAN YOU EAT DAT SHIT, BRO?\nI'M REMOVING IT TO THE SHITLIST!");
            }
        }
    }
}
