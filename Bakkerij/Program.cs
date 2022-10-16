using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using Bakkerij.Enum;
using Bakkerij.Models;

namespace Bakkerij
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList typegebruiker = new ArrayList();
                typegebruiker.Add("Personeel");
                typegebruiker.Add("Klant");
                typegebruiker.Add("Product");

                for (int tg = 0; tg < typegebruiker.Count; tg++)
                {
                    Console.WriteLine("Kies de manier waarom je wilt inloggen in het systeem {0} als {1}", tg, typegebruiker[tg]);
                }
                string keuze = Console.ReadLine();
                int tgk = int.Parse(keuze);
                Console.WriteLine("Je hebt gekozen voor {0} De {1} functies zijn nu beschikbaar", tgk, typegebruiker[tgk]);


                if (tgk == 0)
                {

                    Personeel toevoegen = new Personeel();
                    toevoegen.personeeltoevoegen();
                    toevoegen.display();
                }
                if (tgk == 1)
                {
                    Klant klanttoevoegen = new Klant();
                    klanttoevoegen.klanttoevoegen();
                    klanttoevoegen.display();
                }
                if (tgk == 2)
                {
                    var producten = new List<Taart>();
                    var taarttoevoegen = true;
                    while (taarttoevoegen)
                    {
                        var taart = new Taart();
                        producten.Add(taart);
                        Console.WriteLine("Wil je nog een taart toevoegen? j/n ?");

                        if (Console.ReadLine() == "n")
                        {
                            taarttoevoegen = false;
                        }
                    }
                    Console.WriteLine("Maak keuze om taarten te zien\n 0 voor alle taarten\n 1. voor bepaalde taart \n 2.Wijzig Taart");
                    Showkeuze laatzien = (Showkeuze)int.Parse(Console.ReadLine());
                    switch (laatzien)
                    {
                        case Showkeuze.LaatAllesZien:
                            foreach (var p in producten)
                            {
                                p.display();
                            }
                            break;
                        case Showkeuze.ZoekeenTaart:
                            Console.WriteLine("Geef aub de naam van het product op:");
                            var naamProduct = Console.ReadLine();

                            Taart foundtaart = producten.Find(taart => taart.Productnaam == naamProduct);
                            foundtaart.display();
                            break;

                        case Showkeuze.VeranderTaart:
                            Console.WriteLine("Geef te wijzigen taart op:");
                            var wijzigingTaart = Console.ReadLine();

                            Taart changetaart = producten.Find(taart => taart.Productnaam == wijzigingTaart);   
                            changetaart.display();

                            Taart wijzigen = new Taart();
                            wijzigen.verander();
                            break;

                        default:
                            break;
                    }


                }

            }
            catch (IOException ioe)
            {
                // Exception handler for other input/output exceptions
                // We just print the stack trace on the console
                Console.WriteLine(ioe.StackTrace);
            }
        }
    }
}
