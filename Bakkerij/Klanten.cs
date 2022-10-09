using System;
using System.Collections.Generic;
using System.Text;

namespace Bakkerij
{
    internal class Klanten
    {
        public string naam;
        public string typeklant;
        public string adres;
        public void klant()
        {
                Console.WriteLine("Je voert een {0} op met de naam {1} welk woont op het adres {2}", typeklant, naam, adres);
        }
    }
}

