using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornakkapsulleme
{
    public class Personel
    {
        private string tcNo;

        public string TcNo
        {
            get
            {
                return tcNo.Substring(0,5) + "******";

            }
            set
            {
                bool check = false;
                if(value.Length ==11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {

                        bool isNumber = char.IsNumber(value[i]);

                        if (isNumber)
                        {
                            
                        }
                        else
                        {
                           check = true;
                            break;
                        }
                       
                    }

                    if (check)
                    {
                        Console.WriteLine("TC Kimlik Numarası sadece rakamlardan oluşmalıdır.");
                        
                    }
                    else
                    {
                        tcNo = value;
                    }
                }
                else
                {
                    Console.WriteLine("TC Kimlik Numarası 11 haneli olmalıdır.");
                }

            }


        }
    }
}
