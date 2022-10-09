using System;
using System.Collections.Generic;
using System.Text;

namespace Bakkerij
{
    internal class Personeel
    {
        public string naam;
        public string functie;
        public string adres;
        public string niveau;


        public void display() 
        {
            Console.WriteLine("{0} met de naam {1} woont op het adres {2} en heeft het niveau {3}", functie, naam, adres, niveau);
        }
    }
}
