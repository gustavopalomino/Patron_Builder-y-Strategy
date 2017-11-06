using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{       
    class Program
    {
        static void Main(string[] args)
        {
            int num1=4;
            int num2=2;
            Implementor [] imp= 
            {
                new Sumar(),new Multiplicar(), new Dividir()
            };

            Abstraction [] abst =
            { 
                new RefinedAbstraction(imp[0]), new RefinedAbstraction(imp[1]), new RefinedAbstraction(imp[2])
            };
            for (int i=0; i<3;  i++)
            {
                Console.WriteLine(abst[i].operar(num1, num2));
            }
            Console.ReadLine();
        }
    }
}
