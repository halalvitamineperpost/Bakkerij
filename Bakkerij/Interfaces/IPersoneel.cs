using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bakkerij
{
    public interface IPersoneel
    {
        void personeeltoevoegen();
       string Naam { get; set; }
        string Functie { get; set; }
        string Adres { get; set; }  
        string Niveau { get; set; } 
    }
}
