using System;
using System.Collections.Generic;
using System.Text;

namespace PIII_9
{
    [Flags]
    public enum GrupaWiekowa

   {    
        Brak = 0,     //[0000]
        Dzieci = 1 ,  //[0001]
        Mlodziez = 2, //[0010]
        Dorosli = 4 , //[0101]
        Starsi = 8  //[1000]
        
    }
    public enum Zainteresowania
    {
        Komputery,
        Elektornika,
        Gaming

    }
}
