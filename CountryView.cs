using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    internal class CountryView
    {

        public Country DisplayCountry;
        public CountryView(Country country) 
        {
            DisplayCountry = country;
        }

        public void Display()
        {
            Console.Write("Name: {0}\nContinent: {1}\nMascot: {2}\nColors: ",
                DisplayCountry.Name, DisplayCountry.Continent, DisplayCountry.Mascot);

            // loop through list of colors
            foreach (string color in DisplayCountry.Colors)
            {

                //blue, red, white, green, yellow
                if (color == "Blue") Console.ForegroundColor = ConsoleColor.Blue;
                else if (color == "Red") Console.ForegroundColor = ConsoleColor.Red;
                else if (color == "White") Console.ForegroundColor = ConsoleColor.White;
                else if (color == "Green") Console.ForegroundColor = ConsoleColor.Green;
                else if (color == "Yellow") Console.ForegroundColor = ConsoleColor.Yellow;

                // show comma between colors, but not after the last color
                Console.Write(
                    DisplayCountry.Colors.IndexOf(color) < DisplayCountry.Colors.Count - 1
                    ? $"{color}, "
                    : color
                    );
                
            }
            Console.WriteLine();

        }
        
        

    }
}
