using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    internal class CountryListView
    {
        public List<Country> Countries { get; set; }
        public CountryListView(List<Country> newCountries)
        {
            Countries = newCountries;
        }

        public void Display()
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine("{0} - {1}", i+1, Countries[i].Name);
            }
        }
    }
}
