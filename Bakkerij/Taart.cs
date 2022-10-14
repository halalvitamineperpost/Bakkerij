using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Xml.Linq;

namespace Bakkerij
{
    internal class Taart:Producten
    {
        public double Prijs;
        public string Smaak;

        public Taart()
        {
            Console.WriteLine("Geef smaak van de taart op:");
            Smaak = Console.ReadLine();
            Console.WriteLine("geef aub aktuele prijs op:");
            Prijs = double.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("Productnaam {0}\n, Product omschrijving{1}\n, Product prijs {2}\n Productsoort {3}\n Product smaak {4}\n Product prijs wijziging {5}\n", Productnaam, Productdescription, Productprijs, Productsoort,Smaak, Prijs);
            Console.WriteLine("");
        }
    }
}
