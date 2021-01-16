using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kursu";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            // array - dizi
            // tek tek tanımlamak yerine bir array de tutuyoruz
            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kursu", 
                "programlamaya başlangıç için temel kurs", "Java","phyton","C++"};


            // i=i+2 i yi 2 şer artır demek i+=2 de yazılabilir
            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                // dizi temelli yapıları tek tek döndürür
                // kursları tek tek dolaş 
                // kurs alias

                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfasonu - footer");
        }
    }
}
