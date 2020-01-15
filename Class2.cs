using System;
using System.Collections.Generic;
using System.Text;

namespace PIII_9
{
   public class Class2
    {
        public string tekst;
        public GrupaWiekowa grupawiekowa;
        public Zainteresowania zainteresowania;

        public Class2(string tekst, GrupaWiekowa grupawiekowa, Zainteresowania zainteresowania)
        {
            this.tekst = tekst;
            this.grupawiekowa = grupawiekowa;
            this.zainteresowania = zainteresowania;
        }
    }
}
