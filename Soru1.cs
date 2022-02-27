using System;

namespace AlgorimaSorulari
{
    class Soru1
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            System.Console.WriteLine("Lütfen Pozitif Bir Tam Sayı Giriniz");
            int n = int.Parse(Console.ReadLine());
            int[] dizi = new int[n];
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine("Lütfen {0}. dize sayısını giriniz: ", i+1);
                dizi[i] = int.Parse(Console.ReadLine());
            }

            foreach(var ciftSayi in dizi)
            {
                if(ciftSayi%2==0)
                {
                    System.Console.WriteLine(ciftSayi);
                }
            }
        }
    }
}
