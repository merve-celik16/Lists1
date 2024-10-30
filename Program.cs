using System;
using System.Collections.Generic;



namespace Lists1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Misafirlerimizin isimlerini tutacak bir liste oluşturalım
            List<string> davetliler = new List<string>();

            // Listeye isimler ekleyelim
            davetliler.Add("1- Bülent Ersoy");
            davetliler.Add("2- Ajda Pekkan");
            davetliler.Add("3- Ebru Gündeş");
            davetliler.Add("4- Hadise");
            davetliler.Add("5- Hande Yener");
            davetliler.Add("6- Tarkan");
            davetliler.Add("7- Funda Arar");
            davetliler.Add("8- Demet Akalın");


            // Foreach döngüsü ile listedeki tüm isimleri yazdıralım
            Console.WriteLine("Patika Plus gala gecesine davetlisiniz!");
            foreach (string misafirListesi in davetliler)
            {
                Console.WriteLine(misafirListesi);
            }

        }
    }
}
