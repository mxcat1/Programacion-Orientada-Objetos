using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoP1_POO28519
{
    class Program
    {
        static void Main(string[] args)
        {
            var hola = new{ a=1, b=2, d=3,e="hola" };
            Figura[] arraysfigura = new Figura[5];
            //Triangulo tri1 = new double[2] {5,10 };
            Figura rect1 = new Rectangulo(15,20);
            Figura rect2 = new Rectangulo(20,25);
            Figura tria1 = new Triangulo(3,5);
            Figura tria2 = new Triangulo(2,6);
            Figura tria3 = new Triangulo(5,5);

            arraysfigura[0]= rect1;
            arraysfigura[1]= rect2;
            arraysfigura[2]= tria1;
            arraysfigura[3]= tria2;
            arraysfigura[4]= tria3;

            for (int i=0;i<5;i++)
            {
                Console.WriteLine(arraysfigura[i].CalcularArea());
                arraysfigura[i].DibujarFigura();
                Console.WriteLine("katy estuvo aqui xd");
            }
            Console.ReadLine();
        }
    }
}
