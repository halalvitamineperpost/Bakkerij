using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;
using System.Xml.Linq;

namespace Bakkerij
{
    internal class Producten
    {
        public string Productnaam;
        public string Productdescription;
        public double Productprijs;
        public string Productsoort;

        public Producten()
        {
            try {
                Console.WriteLine("geef aub productnaam op:");
                Productnaam = Console.ReadLine();

                Console.WriteLine("geef aub productomschrijving op:");
                Productdescription = Console.ReadLine();

                Console.WriteLine("geef aub prijs op:");
                Productprijs = double.Parse(Console.ReadLine());

                Console.WriteLine("geef aub productsoort op:");
                Productsoort = Console.ReadLine();
            }
            catch(IOException ioe) 
            {
                // Exception handler for other input/output exceptions
                // We just print the stack trace on the console
                Console.WriteLine(ioe.StackTrace);
            }
            
        }
    }
}
