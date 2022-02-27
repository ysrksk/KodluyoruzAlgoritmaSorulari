using System;

namespace AlgorimaSorulari
{
    class Soru2
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            System.Console.WriteLine("Lütfen Pozitif İki Adet Sayı Giriniz");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Lütfen Karşılaştırılmasını İstediğiniz {0}  Adet Sayıyı Giriniz : ", n);
            int[] dizi = new int[n];
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine("Lütfen {0}.  sayıyı giriniz: ", i+1);
                dizi[i] = int.Parse(Console.ReadLine());
            }
            foreach(var sayi in dizi)
            {
                if(sayi==m || sayi%m==0)
                {
                    System.Console.WriteLine(sayi);
                }
            }


        }
    }
}
