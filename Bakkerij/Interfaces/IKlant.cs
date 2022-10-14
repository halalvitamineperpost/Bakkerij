using System;
using System.Collections.Generic;
using System.Text;

namespace Bakkerij.Interfaces
{
    internal interface IKlant
    {
        void klanttoevoegen();
        string Naam { get; set; }
        string TypeKlant { get; set; }
        string Adres { get; set; }
        string Historie { get; set; }
        string Bestelling { get; set; }
    }

}
