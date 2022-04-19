using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    internal class Program
    {
         
        static void Main(string[] args)
        {
            int[] rndSayilar=new int[10];

            int sayi1 = BirinciSayiyiIste();

            int sayi2 = IkinciSayiyiIste();

            rndSayilar = SayilariTut(sayi1, sayi2);

            if (rndSayilar[0]==0)
            {
                
            }
            else
            {
                SayilariYazdir(rndSayilar);
            }

            if (rndSayilar[0]==0)
            {

            }
            else
            {
                EnBuyukSayiyiBul(rndSayilar);
            }

            if (rndSayilar[0]==0)
            {

            }
            else
            {
                EnKucukSayiBul(rndSayilar);
            }
            
 
            Console.ReadLine();
        }

        private static void EnKucukSayiBul(int[] rndSayilar)
        {
            int enKucukSayi = rndSayilar.Min();
            Console.WriteLine("Rastgele sayılar arasında en küçük olan sayi: {0}",enKucukSayi);
        }

        private static void EnBuyukSayiyiBul(int[] rndSayilar)
        {
            int enBuyukSayi = rndSayilar.Max();
            Console.WriteLine("Rastgele sayılar arasında en büyük olan sayi: {0}",enBuyukSayi);
        }


        private static void SayilariYazdir(int[] islemDizisi)
        {
            Console.WriteLine("Üretilen rastgele sayılar:");

            foreach (int i in islemDizisi)
            {
                Console.WriteLine(i);
            }
        }

        private static int IkinciSayiyiIste()
        {
            Console.WriteLine("İkinci sayiyi giriniz");
            return int.Parse(Console.ReadLine());
        }

        private static int BirinciSayiyiIste()
        {
            Console.WriteLine("Birinci sayiyi giriniz");
            return int.Parse((string)Console.ReadLine());
        }

        public static int[] SayilariTut(int s1,int s2)
        {
            int[] SayilarDizisi = new int[10];
            Random rndsayi = new Random();

            if (s1<s2)
            {
                for (int i = 0; i < SayilarDizisi.Length; i++)
                {
                    SayilarDizisi[i] = rndsayi.Next(s1,s2);
                }             
            }
            else
            {
                Console.WriteLine("Birinci sayi, ikinci sayidan küçük olmalıdır.");
            }

            return SayilarDizisi;
        }


} 

}
