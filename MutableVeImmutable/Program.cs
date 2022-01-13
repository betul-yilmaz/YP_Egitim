using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutableVeImmutable
{
    class Program
    {
        static void Main(string[] args)
        {
            string deneme = "Deneme";
            deneme.ToUpper();
            Console.WriteLine(deneme);
            string deneme2 = deneme.ToUpper();
            Console.WriteLine(deneme2);


            

            Console.ReadLine();
        }

       

    }
}
