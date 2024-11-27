using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}
            //Console.Read();


            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı.");
            //}
            //else
            //{
            //    Console.Write("hatalı bilgi");
            //}
            //Console.Read();

            //int number;
            //Console.Write("Lütfen sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış");
            //}
            //Console.ReadLine();


            //string city;
            //Console.Write("Lütfen bir şehir giriniz: ");
            //city = Console.ReadLine();

            //if (city == "istanbul" | city == "bodrum" | city == "bursa")
            //{
            //    Console.WriteLine("Şehir mevcuttur");
            //}

            //else
            //{
            //    Console.WriteLine("Şehir bulunmamaktadır");
            //}
            //Console.ReadLine(); 

            #endregion

            #region Mod İşlemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Çİft sayıdır");
            //}
            //else
            //{
            //    Console.WriteLine("Tek sayıdır.");
            //}
            #endregion

            #region Örnek Proje Uygulamaları
            //            Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //            Console.WriteLine();
            //            Console.WriteLine("-------------------");
            //            Console.WriteLine("1-Ana Yemekler");
            //            Console.WriteLine("2-Çorbalar");
            //            Console.WriteLine("3-Pizzalar");
            //            Console.WriteLine("4-İçecekler");
            //            Console.WriteLine("5-Tatlılar");
            //            Console.WriteLine("-------------------");
            //            Console.WriteLine();

            //            string menuItem;
            //            Console.Write("detayını görmek istediğiniz menüyü seçiniz: ");
            //            menuItem = Console.ReadLine();

            //            if(menuItem == "1")
            //            {
            //                Console.WriteLine();
            //                Console.WriteLine("---------- Ana Yemekler ----------");
            //                Console.WriteLine();
            //                Console.WriteLine("1-Köri Soslu Tavuk");
            //                Console.WriteLine("2-Kızartma Tabağı");
            //                Console.WriteLine("3-Fasulye Pilav");
            //                Console.WriteLine("4-Fırında Somon");
            //                Console.WriteLine("5-Patlıcan Musakka");
            //                Console.WriteLine("---------- Ana Yemekler ----------");

            //                Console.WriteLine();
            //}
            //            if (menuItem == "2")
            //            {
            //                Console.WriteLine();
            //                Console.WriteLine("---------- Çorbalar ----------");
            //                Console.WriteLine();
            //                Console.WriteLine("1-Mercimek Çorbası");
            //                Console.WriteLine("2-Ezogelin Çorbası");
            //                 Console.WriteLine("---------- Çorbalar ----------");


            //                Console.WriteLine();
            //            }
            //            if (menuItem == "3")
            //            {
            //                Console.WriteLine();
            //                Console.WriteLine("---------- Pizzalar ----------");
            //                Console.WriteLine();
            //                Console.WriteLine("1-Akdeniz Pizza");
            //                Console.WriteLine("2-Margaritha");
            //                Console.WriteLine("3-Tavuklu Pizza");
            //           Console.WriteLine("---------- Pizzalar ----------");


            //                Console.WriteLine();
            //            }

            //            if (menuItem == "4")
            //            {
            //                Console.WriteLine();
            //                Console.WriteLine("---------- İçecekler ----------");
            //                Console.WriteLine();
            //                Console.WriteLine("1-Kola");
            //                Console.WriteLine("2-Ayran");
            //                Console.WriteLine("3-Su");
            //           Console.WriteLine("---------- İçecekler ----------");


            //                Console.WriteLine();
            //            }

            //            if (menuItem == "5")
            //            {
            //                Console.WriteLine();
            //                Console.WriteLine("---------- Tatlılar ----------");
            //                Console.WriteLine();
            //                Console.WriteLine("1-Trileçe");
            //                Console.WriteLine("2-Kazandibi");
            //                Console.WriteLine("3-Sütlaç");
            //               Console.WriteLine("---------- Tatlılar ----------");


            //                Console.WriteLine();
            //            }










            #endregion


            #region Switch Case
            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak");
            //        break;
            //    case 2:
            //        Console.Write("Şubat");
            //        break;
            //    case 3:
            //        Console.Write("Mart");
            //        break;

            //    case 4:
            //        Console.Write("Nisan");
            //        break;

            //    case 5:
            //        Console.Write("Mayıs");
            //        break;

            //    case 6:
            //        Console.Write("Haziran");
            //        break;

            //    case 7:
            //        Console.Write("Temmuz");
            //        break;

            //    case 8:
            //        Console.Write("Ağustos");
            //        break;

            //    case 9:
            //        Console.Write("Eylül");
            //        break;

            //    case 10:
            //        Console.Write("Ekim");
            //        break;
            //    case 11:
            //        Console.Write("Kasım");
            //        break;
            //    case 12:
            //        Console.Write("Aralık");
            //        break;
            //    default:Console.Write("Hatalı Veri Girişi: ");
            //        break ;


            //}



            #endregion


            #region Switch Case Hesap Makinesi

            //int number1,number2,result;
            //char symbol;

            //Console.Write("1.sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());


            //switch (symbol)
            //{
            //    case '+': 
            //        result = number1+number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " +result);
            //        break;
            //}



            #endregion


            Console.ReadLine();
            

            











        }
    }
}
