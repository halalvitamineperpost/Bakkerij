using Bakkerij.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bakkerij.Models
{
    internal class Personeel :IPersoneel
    {      

        public string Naam { get; set; }
        public string Functie { get; set; }
        public string Adres { get; set; }
        public string Niveau { get; set; }
        public object Persoon { get; private set; }

        public Personeel()
        {
            Console.WriteLine("\n 0. voor toevoegen Inkoper\n 1. voor toevoegen verkoper\n 2. voor toevoegen manager");

            FunctieOmschrijving keuzefunctie = (FunctieOmschrijving)int.Parse(Console.ReadLine());

            switch (keuzefunctie)
            {
                case FunctieOmschrijving.Inkoper:                    
                    Console.WriteLine("Inkoper geselecteerd:");
                    break;
                case FunctieOmschrijving.Verkoper:
                    Console.WriteLine("Verkoper geselecteerd:");
                    break;
                case FunctieOmschrijving.Manager:
                    Console.WriteLine("Manager geselecteerd:");
                    break;
                default:

                    break;
            }
         
            //string description = Enumerations.GetEnumDescription((FunctieOmschrijving)keuzefunctie);

            Console.WriteLine("Geef naam op:");
            Naam = Console.ReadLine();


            Console.WriteLine("Geef adres op:");
            Adres = Console.ReadLine();

            Console.WriteLine("Geef niveau op:");
            Niveau = Console.ReadLine();
                       
        }
        public void personeeltoevoegen()
        {
            var personeel = new List<Personeel>();
            var doorgaan = true;

            while (doorgaan)
            {
                var werknemer = new Personeel();         
               
                personeel.Add(werknemer);

                Console.WriteLine("wil je doorgaan om de medewerker op te voeren j/n?");

                if (Console.ReadLine() == "n")
                {
                    doorgaan = false;
                }
            }
            foreach (var yildirim in personeel)
            {
                yildirim.display();
            }
        }
        public void display() => Console.WriteLine("{0}met de naam {1} woont op het adres {2} en heeft het niveau {3}", Functie, Naam, Adres, Niveau);

    }
}
