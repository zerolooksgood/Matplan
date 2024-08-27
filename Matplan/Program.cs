using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matplan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oppg 1
            Dictionary<string, string[]> beboere = new Dictionary<string, string[]>();
            beboere.Add("marius", new string[] { "Brød", "Wraps", "Fajitas" });
            beboere.Add("millie", new string[] { "Sjokolade Crêpes", "Te og Toast", "Big Mac" });
            beboere.Add("tonitsveta", new string[] { "Frokostblanding", "Sandwich", "Pasta" });

            //Oppg 2.1
            foreach (KeyValuePair<string, string[]> i in beboere)
            {
                Console.WriteLine($"{i.Key} spiser {i.Value[0]} til frokost, {i.Value[1]} til lunsj og {i.Value[2]} til middag.");
            }

            //Oppg 2.2
            Console.WriteLine("\nHvilken beboer vil du vite om?");
            string key = Console.ReadLine().ToLower();
            string[] value = new string[3];

            if (beboere.ContainsKey(key))
            {
                value = beboere[key];
                //Oppg 2.3
                Console.WriteLine($"{key} spiser {value[0]} til frokost, {value[1]} til lunsj og {value[2]} til middag.");
            } else
            {
                //Oppg 2.4
                Console.WriteLine($"{key} er ikke en beboer.");
            }

            Console.ReadLine();
        }
    }
}
