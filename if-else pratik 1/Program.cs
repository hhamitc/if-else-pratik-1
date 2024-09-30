using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_pratik_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bu kod bir sayının 10 dan büyük, küçük veya 10'a eşit olduğunu kontrol edip ona göre cevap verir,
            // Ardından sayının çift mi tek mi olduğunu kontrol eder.
            
            

            Console.Write($"Bir sayı giriniz: "); //Örnekte görselde olduğu gibi girilen sayıyı alt satıra değil de aynı satıra yazdırmak için WriteLine yerine sadece Write kullandım.
            int number = int.Parse(Console.ReadLine());
          

            if (number > 10)
            {
                Console.WriteLine("Sayı 10'dan büyüktür.");
            }
            else if (number == 10)
            {
                Console.WriteLine("Sayı 10'a eşittir.");
            }
            else 
            {
                Console.WriteLine("Sayı 10'dan küçüktür.");
            }
            if (number % 2 == 0)
            {
                Console.WriteLine("Sayı çift sayıdır.");
            }
            else
            {
                Console.WriteLine("Sayı tek sayıdır.");
            }


            Console.Read();
        }
    }
}
