using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[4] = 748;
            //Console.WriteLine(numbers[3]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(numbers[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listele

            // string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil" };
            //for (int i = 0; i < colors.Length; i++) { 
            //   Console.WriteLine(colors[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 798, 86, 100 };
            //int max = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > max) { 
            //    max = myArray[i];
            //    }
            //}
            //Console.WriteLine(max);

            //string[] persons = { "ali", "ahmet", "ayşe" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++) { 
            //     Console.WriteLine(numbers[i]); 
            //}


            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers); diziyi tersten sıralıyor
            //for (int i = 0; i < numbers.Length; i++) { 
            //     Console.WriteLine(numbers[i]); 
            //}




            #endregion


            #region Dizi Metodları
            //string[] customers = { "ali", "ayşe", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);




            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++) {

            //    Console.Write($" {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers= { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220};

            //Console.WriteLine("Çift Sayılar");
            //for (int i = 0; i< numbers.Length; i++)
            //{
            //    if (numbers[i] %2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //} 
            //    Console.WriteLine();
            //    Console.WriteLine("Tek Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}




            #endregion



            Console.Read();

        }
    }
}
