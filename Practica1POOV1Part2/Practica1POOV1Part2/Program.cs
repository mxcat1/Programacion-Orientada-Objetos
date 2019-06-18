using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pregunta1;
using Pregunta2;

namespace Practica1POOV1Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            CliContado C1 = new CliContado();
            C1.Clave = 12;
            Honorarios<CliContado> H1 = C1;
            Console.WriteLine(H1.Cliente.Clave);
            Console.ReadLine();
        }
    }
}
