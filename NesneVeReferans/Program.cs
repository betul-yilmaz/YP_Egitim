using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneVeReferans
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek ornek; //Ornek tipinde ornek referans tipi oluşturuluyor.
            //stackte referans noktası oluştu ve değeri heapte
            int sayi = 0;  
            Ornek ornek2 = new Ornek(); //Ornek() sınıfından bir nesne oluşturuldu ve Ornek tipinde bir referansla işaretlendi
            new Ornek(); //referanssız bir nesne oluşturuldu

            Ornek x = null;
            x = new Ornek();

            Ornek a = new Ornek();
            Ornek b = a;

            int s1 = 3;
            int s2 = s1;  
        }
    }
}
