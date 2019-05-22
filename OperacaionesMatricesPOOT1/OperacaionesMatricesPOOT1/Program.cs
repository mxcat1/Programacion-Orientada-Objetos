using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacaionesMatricesPOOT1
{
    class Program
    {
        //public static void multiplesparametros(params int[] a)
        //{
        //    for (int s=0;s<a.Length;s++) {
        //        Console.WriteLine(a[s]);
        //    }
        //}
        static void Main(string[] args)
        {
            Matriz a = new Matriz();
            a.llenarmatrizale(1,10);
            Console.WriteLine("Matriz "+nameof(a));
            a.verMatriz();
            Matriz b = new Matriz();
            b.llenarmatrizale(10, 20);
            Console.WriteLine("Matriz " + nameof(b));
            b.verMatriz();
            //solo para matrices de 3x3
            Matriz prueba = new Matriz();
            prueba.llenarmatriz(1,2,3,4,5,6,7,8,9);
            Console.WriteLine("Matriz " + nameof(prueba));
            prueba.verMatriz();
            //XD

            Matriz c = a - b;
            Console.WriteLine(string.Format("Suma de Matriz {0} Mas Matriz {1} igual a Matriz {2}", nameof(a), nameof(b), nameof(c)));
            c.verMatriz();

            Matriz d = a * b;
            Console.WriteLine(string.Format("Multiplicacion de Matriz {0} Por Matriz {1} igual a Matriz {2}", nameof(a), nameof(b), nameof(d)));
            d.verMatriz();

            Console.ReadLine();
        }
    }
}
