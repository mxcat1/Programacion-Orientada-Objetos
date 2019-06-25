using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1aPOO26062019
{
    class Celular
    {
        private Bateria _bateria;
        private SimCard _simcard;
        private MemoriaCard _memoria;
        private Mensaje _mensajes = new Mensaje();
        private Camara _camara = new Camara();
        private Software _software = new Software();
        public Celular()
        {
            _bateria = new Bateria();
            _simcard = new SimCard();
            _memoria = new MemoriaCard();
        }
        public Celular(Bateria b,SimCard sc,MemoriaCard mc)
        {
            _bateria = b;
            _simcard = sc;
            _memoria = mc;
        }
    }
    class Bateria
    {

    }
    class SimCard
    {

    }
    class MemoriaCard
    {

    }
    class Mensaje
    {

    }
    class Camara
    {

    }
    class Software
    {

    }
}
