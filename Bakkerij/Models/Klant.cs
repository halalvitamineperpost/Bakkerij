using Bakkerij.Enum;
using Bakkerij.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bakkerij.Models
{
    internal class Klant : IKlant
    {
        public string Naam { get; set; }
        public string TypeKlant { get; set; }
        public string Adres { get; set; }
        public string Historie { get; set; }
        public string Bestelling { get; set; }

        public Klant()
        {
            Console.WriteLine("\n Kies\n 0. voor Consument klant \n 1. voor zakelijke klant\n");

            TypeKlant keuzetypeklant = (TypeKlant)int.Parse(Console.ReadLine());

            switch (keuzetypeklant)
            {
                case Enum.TypeKlant.Consument:
                    Console.WriteLine("Consument geselecteerd:");
                    break;
                case Enum.TypeKlant.Zakelijk:
                    Console.WriteLine("Zakelijk geselecteerd:");
                    break;               
                default:

                    break;
            }

            //string description = Enumerations.GetEnumDescription((FunctieOmschrijving)keuzefunctie);

            Console.WriteLine("Geef naam op:");
            Naam = Console.ReadLine();


            Console.WriteLine("Geef adres op:");
            Adres = Console.ReadLine();

            Console.WriteLine("Geef historie op:");
            Historie = Console.ReadLine();

            Console.WriteLine("Geef bestelling op:");
            Bestelling = Console.ReadLine();

        }

        public void klanttoevoegen()
        {
            var klanten = new List<Klant>();
            var doorgaan = true;

            while (doorgaan)
            {
                var klant = new Klant();

                klanten.Add(klant);

                Console.WriteLine("wil je doorgaan om een klant op te voeren j/n?");

                if (Console.ReadLine() == "n")
                {
                    doorgaan = false;
                }
            }
            foreach (var yildirim in klanten)
            {
                yildirim.display();
            }
        }
        public void display() => Console.WriteLine("Klant naam: {0}\n Wonende op het adres {1}\n  Met bestel historie{2}\n Heeft het volgende besteld:{3}\n ",Naam, Adres, Historie, Bestelling);
    }

}
