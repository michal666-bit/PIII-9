using System;

namespace PIII_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var reklama = new Class2("Kup teraz", GrupaWiekowa.Dorosli | GrupaWiekowa.Mlodziez, Zainteresowania.Elektornika);

            for (int i = 0; i <= GrupaWiekowa.Dorosli.SumaGrupWiekowych(); i++)
            {
                Console.WriteLine((GrupaWiekowa)i);

            }
           // string fraza = Console.ReadLine();
          //  Console.WriteLine("Ala ma kota".ZliczZnaki("a"));

           // int liczba = Convert.ToInt32(Console.ReadLine());
          //  int wynik, reszta;
           // (wynik,reszta) =liczba.DzielenieZReszta(3);
          //  Console.WriteLine($"{liczba}/3={wynik}r{reszta}");
        }
    }
}
