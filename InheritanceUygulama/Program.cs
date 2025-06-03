using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Çalışan Uygulamasına hoşgeldiniz...");

            Console.WriteLine("1 - Yazılımcı İşlemleri");
            Console.WriteLine("2 - Yönetici İşlemleri");
            Console.WriteLine("Çıkış İçin Q'ya basınız.");
            Console.Write("Lütfen bir seçim yapınız: ");
            string secim = Console.ReadLine();


            while (true)
            {
                if (secim == "q" | secim == "Q")
                    return;
                else if (secim == "1")
                {
                    Console.WriteLine("Yazılımcı İşlemleri");
                    Yazilimci yazilimci = new Yazilimci(2, "Mehmet", "Kara", "C#, Java, Python");
                    yazilimci.Bilgilerigoster();
                    yazilimci.formatAt("Windows 11");
                    break;
                }
                else if (secim == "2")
                {
                    Console.WriteLine("Yönetici İşlemleri");
                    Yonetici yonetici = new Yonetici(3, "Ayşe", "Demir", 5);
                    yonetici.Bilgilerigoster();
                    yonetici.ZamYap(1000);
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    break;

                    

                }

                

            }
            Console.ReadLine();
        }
    }
}
