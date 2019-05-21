using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargaOperadoresPOO_21519
{

    class cuadrado
    {
        private double _Lado;
        public cuadrado(int l)
        {
            _Lado = (double)l;
        }
        public cuadrado(double l)
        {
            _Lado = l;
        }
        public override string ToString()
        {
            return string.Format("lado: {0} , area: {1}", this._Lado.ToString(), this._Lado * this._Lado);
        }
        public static cuadrado operator +(cuadrado a, cuadrado b){

            //double ladonuevo = Math.Sqrt(Math.Pow(a._Lado,2) + Math.Pow(b._Lado,2));
            //cuadrado c = new cuadrado(ladonuevo);

            return new cuadrado(a._Lado + b._Lado);
        }

        public static implicit operator cuadrado(double a)
        {
            return new cuadrado(a);
        }

        public static implicit operator cuadrado(string a)
        {
            return new cuadrado(double.Parse(a));
        }
        public static bool operator ==(cuadrado a, cuadrado b)
        {
            return a._Lado == b._Lado;
        }
        public static bool operator !=(cuadrado a, cuadrado b)
        {
            return a._Lado != b._Lado;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            cuadrado a = new cuadrado(2);
            cuadrado b = new cuadrado(4);
            cuadrado c = a + b;
            //operacion implisito
            cuadrado e = 2;
            // sobrecarga de operador == booleano
            Console.WriteLine(a==b);
            Console.WriteLine(e.ToString());
            Console.ReadLine();

        }
    }
}
