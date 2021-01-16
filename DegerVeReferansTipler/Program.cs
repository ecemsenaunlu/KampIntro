using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {


            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 çıktısı 30
            // int decimal float double bool değer tip
            // array class interface referans tip (adres tutar)

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; //sayilar1 in referans numarası eşittir sayilar2 nin referans numarası pointer mantığı
            sayilar2[0] = 999;
            //sayilar1[0] çıktısı 999 çünkü diziler bir referansla yani adresle tutulur
            
        }
    }
}
