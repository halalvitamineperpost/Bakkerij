using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Bakkerij
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList typegebruiker = new ArrayList();
            typegebruiker.Add("Personeel");
            typegebruiker.Add("Klant");

            for (int tg = 0; tg < typegebruiker.Count; tg++)
            {
                Console.WriteLine("Kies de manier waarom je wilt inloggen in het systeem {0} als {1}", tg, typegebruiker[tg]);
            }
            string keuze = Console.ReadLine();
            int tgk = int.Parse(keuze);
            Console.WriteLine("Je hebt gekozen voor {0} De {1} functies zijn nu beschikbaar", tgk, typegebruiker[tgk]);


            if (tgk == 0)
            {
                ArrayList medewerkerfunctie = new ArrayList();
                medewerkerfunctie.Add("Inkoper");
                medewerkerfunctie.Add("Verkoper");
                medewerkerfunctie.Add("Manager");

                for (int mf = 0; mf < medewerkerfunctie.Count; mf++)
                {
                    Console.WriteLine("Selecteer je functie {0} voor {1}", mf, medewerkerfunctie[mf]);
                }
                var personeel = new Personeel();
                string typefunctie = Console.ReadLine();
                int mdf = int.Parse(typefunctie);
                var password = new Password();
                Console.WriteLine("Voer wachtwoord in:");
                password.wachtwoord = Console.ReadLine();
                //if (password.wachtwoord != false)
                //{

                //}

                if (mdf == 0)
                {
                    Console.WriteLine("Je hebt de functie {0} wat betekend dat je {1} bent.", mdf, medewerkerfunctie[mdf]);
                    var inkopers = new List<Personeel>();

                    var doorgaan = true;

                    while (doorgaan)
                    {
                        var inkoper = new Personeel();

                        Console.WriteLine("Geef aub de naam van de inkoper op ");
                        inkoper.naam = Console.ReadLine();

                        Console.WriteLine("Geef aub de adres van de inkoper op ");
                        inkoper.adres = Console.ReadLine();

                        Console.WriteLine("Geef aub de functie op: ");
                        inkoper.functie = Console.ReadLine();

                        Console.WriteLine("Geef het niveau op (senior, medir, junior) : ");
                        inkoper.niveau = Console.ReadLine();

                        Console.WriteLine("Wil je nog een inkoper toevoegen j/n?:");

                        if (Console.ReadLine() == "n")
                        {

                            doorgaan = false;

                        }
                        inkopers.Add(inkoper);
                    }
                    foreach (var inkoper in inkopers)
                    {
                        inkoper.display();
                    }
                }
                if (mdf == 1)
                {
                    Console.WriteLine("Je hebt de functie {0} wat betekend dat je {1} bent.", mdf, medewerkerfunctie[mdf]);
                    var verkopers = new List<Personeel>();

                    var doorgaan = true;

                    while (doorgaan)
                    {
                        var verkoper = new Personeel();

                        Console.WriteLine("Geef aub de naam van de verkoper op ");
                        verkoper.naam = Console.ReadLine();

                        Console.WriteLine("Geef aub de adres van de verkoper op ");
                        verkoper.adres = Console.ReadLine();

                        Console.WriteLine("Geef aub de functie op: ");
                        verkoper.functie = Console.ReadLine();

                        Console.WriteLine("Geef het niveau op (senior, medir, junior) : ");
                        verkoper.niveau = Console.ReadLine();

                        Console.WriteLine("Wil je nog een verkoper toevoegen j/n?:");

                        if (Console.ReadLine() == "n")
                        {

                            doorgaan = false;

                        }
                        verkopers.Add(verkoper);
                    }
                    foreach (var verkoper in verkopers)
                    {
                        verkoper.display();
                    }
                }
                if (mdf == 2)
                {
                    Console.WriteLine("Je hebt de functie {0} wat betekend dat je {1} bent.", mdf, medewerkerfunctie[mdf]);
                    var managers = new List<Personeel>();

                    var doorgaan = true;

                    while (doorgaan)
                    {
                        var manager = new Personeel();

                        Console.WriteLine("Geef aub de naam van de manager op ");
                        manager.naam = Console.ReadLine();

                        Console.WriteLine("Geef aub de adres van de inkoper op ");
                        manager.adres = Console.ReadLine();

                        Console.WriteLine("Geef aub de functie op: ");
                        manager.functie = Console.ReadLine();

                        Console.WriteLine("Geef het niveau op (senior, medir, junior) : ");
                        manager.niveau = Console.ReadLine();

                        Console.WriteLine("Wil je nog een inkoper toevoegen j/n?:");

                        if (Console.ReadLine() == "n")
                        {

                            doorgaan = false;

                        }
                        managers.Add(manager);
                    }
                    foreach (var manager in managers)
                    {
                        manager.display();
                    }
                }



            }

            if (tgk == 1)
            {
                ArrayList typeklant = new ArrayList();

                typeklant.Add("Consument");
                typeklant.Add("Zakelijk");

                for (int tk = 0; tk < typeklant.Count; tk++)
                {
                    Console.WriteLine("Maak een keuze {0} of {1} om een klant te kunnen opvoeren in het systeem", tk, typeklant[tk]);
                }
                string keuze1 = Console.ReadLine();
                int tkk = int.Parse(keuze1);
                Console.WriteLine("Je hebt de keuze {0} gekozen dit betekend dat je {1} klant opvoerd in het systeem", tkk, typeklant[tkk]);
                if (tkk == 0)
                {
                    Console.WriteLine("Je hebt {0} gekozen dit betekend dat je {1} klant opvoerd in het systeem.", tkk, typeklant[tkk]);
                    var klanten = new List<Klanten>();

                    var doorgaan = true;

                    while (doorgaan)
                    {
                        var klant = new Klanten();

                        Console.WriteLine("Geef aub de naam van de klant op ");
                        klant.naam = Console.ReadLine();

                        Console.WriteLine("Geef aub de adres van de klant op ");
                        klant.adres = Console.ReadLine();

                        Console.WriteLine("Geef aub of het een zakelijke of consumet klant is op: ");
                        klant.typeklant = Console.ReadLine();
                       
                        Console.WriteLine("Wil je nog een klant toevoegen j/n?:");

                        if (Console.ReadLine() == "n")
                        {

                            doorgaan = false;

                        }
                        klanten.Add(klant);
                    }
                    foreach (var klant in klanten)
                    {
                        klant.klant();
                    }
                }
            }
                if (tgk == 1)
                {
                Console.WriteLine("zakelijk");
                }
            }


        }
    }
