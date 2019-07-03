using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosPOO3719
{
    class Clases
    {
        //Metodo como Delegado
        public static void MetodoRadio(string Mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Estamos en la clase radio");
            Console.WriteLine($"Este es un mensaje {Mensaje}");
        }

        public delegate void Metodo(string Mensaje);
    }
    class Pastel
    {
        //Metodo como Delegado
        public static void MostrarPastel(string anuncio)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Estamos en la clase Pastel");
            Console.WriteLine($"Este es un mensaje Pastel {anuncio}");
        }
    }

    public delegate void dDescongelado(int grados);
    public delegate void dKilosReservasBajas(int kilos);

    class CRefri
    {



        private dDescongelado _delDescongelado;
        private dKilosReservasBajas _delReservasBajas;

        private int _Grados;
        private int _KilosAlimento;
        public CRefri(int k,int g)
        {
            _Grados = g;
            _KilosAlimento = k;
        }
        //Multicasting
        public void AdicionarMetodoReserva(dKilosReservasBajas pmetodo)
        {
            _delReservasBajas += pmetodo;
        }
        //public void AdicionarMetodoReserva(dKilosReservasBajas pmetodo)
        //{
        //    _delReservasBajas = pmetodo;
        //}
        public void EliminarMetodoReserva(dKilosReservasBajas pmetodo)
        {
            _delReservasBajas -= pmetodo;
        }
        public void AdicionarMetodoDescongelado(dDescongelado pmetodo)
        {
            _delDescongelado += pmetodo;
        }
        //public void AdicionarMetodoDescongelado(dDescongelado pmetodo)
        //{
        //    _delDescongelado = pmetodo;
        //}
        public void EliminarMetodoDescongelado(dDescongelado pmetodo)
        {
            _delDescongelado -= pmetodo;
        }
        
        public int KilosAlimento { get { return _KilosAlimento; } }
        public int Grados { get { return _Grados; } }


        public void Trabajar(int pConsumo)
        {
            _KilosAlimento -= pConsumo;
            _Grados += 1;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"{KilosAlimento} Kilos {Grados} Grados");
            if (KilosAlimento < 10)
            {
                _delReservasBajas(KilosAlimento);
            }
            if (Grados > 0)
            {
                _delDescongelado(Grados);
            }
        }

    }
    class CTienda
    {
        public static void MandarViveres(int pkilos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Estamos en la clase Tienda");
            Console.WriteLine($"Viveres por {pkilos} Kilos");
        }
    }
}
