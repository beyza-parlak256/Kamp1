using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, decimal, float, double, bool(1 and 0) = değer tip
            // array, class, interface = referans tip

            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 ??? --> sayi1 = 30 (değer tip)

            int[] sayilar1 = new[] { 10, 20, 30 };
            int[] sayilar2 = new[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // sayilar1[0] = ??? --> 999 (referans tip)
            // adresi eşitliyoruz sayilar1 ile sayilar2 eş oluyor
        }
    }
}
