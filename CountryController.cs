using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    internal class CountryController
    {


        List<Country> CountryDB = new List<Country>()
        {
            new Country("USA", "America", "Eagle", new List<string>(){"Blue", "Red", "White"}),
            new Country("Brazil", "LatinAmerica", "Parrot", new List<string>(){"Green", "Yellow", "Blue", "White"}),
            new Country("New Zealand", "Australia", "Kangaroo", new List<string>(){"Blue", "Red", "White"}),
        };

        public void CountryAction(Country country)
        {
            CountryView countryView = new CountryView(country);
            countryView.Display();
        }

        public void WelcomeAction()
        {

            Console.WriteLine("Welcome to the country app - please select a country number from the list below:");

            bool runProgram = false;
            do // run the program at least once
            {

                CountryListView listView = new CountryListView(CountryDB);
                listView.Display();
                int choice = int.Parse(Console.ReadLine());
                choice -= 1; // normalize user input

                Console.WriteLine();
                CountryAction(CountryDB[choice]);

                Console.WriteLine();
                Console.WriteLine("Would you like to see another country? y/n");
                string repeat = Console.ReadLine();

                if (repeat != null && repeat.Trim().ToLower().Contains("y")) runProgram = true;
                else runProgram = false;

                Console.WriteLine();
            } while (runProgram);
        
        }
    }
}
