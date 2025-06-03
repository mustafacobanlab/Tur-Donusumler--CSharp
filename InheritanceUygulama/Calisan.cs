using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUygulama
{
    public class Calisan
    {
        private int id;
        private string name;
        private string surname;




        public int getId()
        {
            return this.id;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getSurname()
        {
            return this.surname;
        }
        public void setSurname(string surname)
        {
            this.surname = surname;
        }






        public Calisan(int id, string name, string surname)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;

        }

        public  void Bilgilerigoster()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Ad: " + this.name);
            Console.WriteLine("Soyad: " + this.surname);
        }
    }
}
