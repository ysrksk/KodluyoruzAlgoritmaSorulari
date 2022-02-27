using System;

namespace AlgorimaSorulari
{
    class Soru4
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.WriteLine("Bir Cümle Giriniz ");
            string cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(" ");
            char[] harfler = cumle.ToCharArray();

            Console.WriteLine(kelimeler.Length);
            Console.WriteLine(harfler.Length);

        }
    }
}
