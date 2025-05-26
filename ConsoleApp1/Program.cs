using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            byte b = (byte)a;
            Console.WriteLine(b.GetType());

            string number = "50";

            int number1 = int.Parse(number);

            bool check = number1.GetType() == typeof(int);
            bool check1 = number1.GetType() == typeof(string);

            Console.WriteLine(check);
            Console.WriteLine(check1);

            string numb = "3.14";
            double numb1 = Convert.ToDouble(numb, CultureInfo.InvariantCulture);
            double sonuc = numb1 * number1;
            Console.WriteLine(sonuc);

            Console.Write("Lütfen Yaşınızı Giriniz: ");
            int age = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Yaşınızın 2 ile çarpımı: "+age * 2);

            Console.Read();
        }
    }
}
