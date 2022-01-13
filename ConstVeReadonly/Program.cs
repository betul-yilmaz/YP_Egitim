using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVeReadonly
{
    public class ConstReadonly
    {
        public const double PI = 3.14;
        
        public readonly int a = 5;
        public readonly int b;
        public ConstReadonly(int deger)
        {           
            b = deger;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConstReadonly deneme = new ConstReadonly(10);
            Console.WriteLine("b:"+deneme.b);
            Console.WriteLine("a:"+deneme.a);
            Console.WriteLine(ConstReadonly.PI);
            Console.ReadLine();
        }
    }
    
}
