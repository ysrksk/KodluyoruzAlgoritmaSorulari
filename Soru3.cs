using System;

namespace AlgorimaSorulari
{
    class Soru3
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            System.Console.WriteLine("Lütfen Pozitif Bir Tam Sayı Giriniz");
            int n = int.Parse(Console.ReadLine());
            string[] dizi = new string[n];
            System.Console.WriteLine("Lütfen İstediğiniz {0}  Adet Kelime Giriniz : ", n);
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine("Lütfen {0}.  Kelimeyi Giriniz: ", i+1);
                dizi[i] = Console.ReadLine();
            }
            Array.Reverse(dizi);
            foreach (var kelime in dizi)
            {
                System.Console.WriteLine(kelime);
            }
        }
    }
}
