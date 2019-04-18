using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Constructora_POO4_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Edificio O = new Edificio(3);
            O.DefinirHabitaciones(0,3);
        }
    }
}
