using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    internal class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }
        public string Mascot { get; set; }
        public List<string> Colors { get; set; }

        public Country(string newName, string myContinent, string newMascot, List<string> newColors) 
        { 
            Name = newName;
            Continent = myContinent;
            Mascot = newMascot;
            Colors = newColors;
        }

    }
}
