using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorVeGarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                new Ornek(i);
            } 
            GC.Collect();

            Console.Read();

        }
        class Ornek
        {
            int id;
            public Ornek(int id)
            {
                this.id = id;
                Console.WriteLine(id+ ".nesne üretildi");
            }
            ~Ornek()
            {
                Console.WriteLine(id + ".nesne silindi");
            }
        }
    }
}
