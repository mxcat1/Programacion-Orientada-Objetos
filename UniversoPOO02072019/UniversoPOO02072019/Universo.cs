using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversoPOO02072019
{
    class EnteAstronomico
    {
        public string nombre { get; set; }
        public double Diametro { get; set; }
    }
    class Universo
    {
        public Galaxias[] galaxias;
    }
    class Planeta:EnteAstronomico
    {
        
        public Estrella OrbitaEstrella;
    }
    class Galaxias : EnteAstronomico
    {
        public Planeta[] planetas;
    }
    class Estrella : EnteAstronomico
    {

    }
    class Satelites
    {

    }
    class Asteroides
    {

    }
    class Cometas
    {

    }
}
