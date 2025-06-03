using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var name = "bu bir var değişkenidir"; // String variable
            dynamic Name = "bu bir dynamic değişkenidir";
            object namE = "bu bir object değişkenidir";
            const decimal euler = 0.57721566490153286060651209008240243104215933593992m;
            const float pi = 3.14f; // Pi constant
            Console.WriteLine(pi);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Pi Sayısı {0}'dır, Euler Sabiti {1}'dır. ", pi, euler);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(Name);
            Console.WriteLine(namE);

          
            
                


            


        }
    }
}
