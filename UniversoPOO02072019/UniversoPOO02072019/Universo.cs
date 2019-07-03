using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversoPOO02072019
{
    abstract class EnteAstronomico
    {
        public string Nombre { get; set; }
        public double Diametro { get; set; }
        public double TiempoVida { get; set; }
        public float Gravedad { get; set; }
    }
    class Universo
    {
        public Galaxias[] galaxias;
    }
    class Planeta:EnteAstronomico
    {
        
        public Estrella OrbitaEstrella;
        public Satelites[] SatelitePlaneta;
    }
    class Galaxias : EnteAstronomico
    {
        public List<Planeta> PlanetasGalaxia;
        public List<Estrella> EstrellasGalaxia;
        public List<Asteroides> AsteroidesGalaxia;
        public List<Cometas> CometasGalaxia;
        public List<Cuasar> CuasaresGalaxias;
        public Galaxias()
        {
            CuasaresGalaxias = new List<Cuasar>();
        }
        public void EstrellaaCuasar(Estrella E) {

            CuasaresGalaxias.Add((Cuasar)E);
        }
    }
    class Estrella : EnteAstronomico
    {
        public Estrella()
        {

        }
    }
    class Satelites:EnteAstronomico
    {
        
    }
    class Asteroides:EnteAstronomico
    {

    }
    class Cometas:EnteAstronomico
    {

    }
    class Cuasar : Estrella
    {

    }
}
