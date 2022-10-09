using System;
using System.Collections.Generic;
using System.Text;

namespace Bakkerij
{
    internal class Password
    {
        public string wachtwoord;


        public void Wachtwoord()
        {
            Console.WriteLine("Voer je wachtwoord in:");

            var wachtwoord = Console.ReadLine();
            var i = 0;
            var p = 3;
            while (wachtwoord != "security" && i < 2)
            {
                i++;
                p--;
                Console.WriteLine("Wachtwoord is fout");
                Console.WriteLine("Je hebt nog" + p + "pogingen te gaan");
                Console.WriteLine("Geef wachtwoord op:");
            }
            Console.WriteLine("Je wordt ingelogd");
        }

    }
}
