using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaInterfacesPOOv1
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura F1 = new Factura();
            F1.Folio = 1;
            F1.Cliente = "Jose";
            F1.Total = 150;
            F1.Fecha = DateTime.Now;

            Console.WriteLine(F1.MostrarDatos());
            Console.WriteLine(F1.FechaConLetra());
            Console.WriteLine(F1.ToString());
            Console.WriteLine(F1.PruebaFecha(DateTime.Now));
            Console.ReadLine();

        }
    }
}
