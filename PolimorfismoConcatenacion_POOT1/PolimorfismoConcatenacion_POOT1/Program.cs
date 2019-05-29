using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PolimorfismoConcatenacion_POOT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primera Forma");
            MiStringI cadena = new MiStringI("aaaa"," ","bdd"," ","cff");
            Console.WriteLine(cadena);

            Console.WriteLine("Segunda Forma");
            MiStringII c1 = "hola";
            MiStringII c2 = "mundo";
            MiStringII c3 = PolimorfismoConcatenacion_POOT1.MiStringII.sumarstring(c1," ",c2," ","hola");
            Console.WriteLine(c3);

            Console.WriteLine("Tercera Forma");
            MiStringIII a1 = 1;
            MiStringIII a2 = "hola";
            MiStringIII a3 = a1+ 1.05 + a2;

            Console.WriteLine(a3);
            Console.ReadLine();
        }
    }
}
