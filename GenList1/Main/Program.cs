using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();

            menu.Content.ForEach(x => menu.RemoveFromMenu += x.RemoveToTheShitList);


            Console.WriteLine("Menu:\n");
            menu.Content.ForEach(x => Console.WriteLine(x.Name));

            menu.Content
                .Where(x => x.Name == "Sushi" || x.Name == "Ramen")
                .ToList()
                .ForEach(x => menu.Remove(x));

            Console.WriteLine("\nUpdated menu:\n");
            menu.Content.ForEach(x => Console.WriteLine(x.Name));

            Console.WriteLine("\nShit:\n");
            menu.ShitList.ForEach(x => Console.WriteLine(x.Name));
        }


    }
}
