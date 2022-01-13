using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Type
            int sayi1 = 5;
            int sayi2 = 10;
            Console.WriteLine("sayi1: "+ sayi1 + "\nsayi2: " + sayi2);           
            sayi1 = sayi2;
            Console.WriteLine("sayi 1'in yeni değeri:"+ sayi1);
            

            double double1 = 10.1;
            double double2 = 20.1;
            Console.WriteLine("double1: " + double1 + "\ndouble2: " + double2); 
            double2 = double1;
            Console.WriteLine("double 2'nin yeni değeri:" + double2);

            //Reference Type
            string[] sehir1 = new string[] { "istanbul", "sakarya", "kocaeli" };
            string[] sehir2 = new string[] { "bursa", "yalova", "balıkesir" };
            Console.WriteLine("sehir2[0]: " + sehir2[0]);
            sehir2 = sehir1;
            Console.WriteLine("sehir2[0]: " + sehir2[0]);
            sehir1[0] = "bilecik";
            Console.WriteLine(sehir2[0]);

            string isim1 = "betül";
            string isim2 = "ozge";
            Console.WriteLine("isim11: " + isim1 + "\nisim2: " + isim2);
            isim2 = isim1;
            Console.WriteLine("isim 2'nin yeni değeri:" + isim2);


            Console.ReadLine();

        }
    }
}
