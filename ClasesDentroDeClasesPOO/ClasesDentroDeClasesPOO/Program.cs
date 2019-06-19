using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDentroDeClasesPOO
{
    class huevo
    {

    }
    class Matrioshka<T>
    {
        T _boneca;
        string Nombre { get;set; }
     
        public Matrioshka(string name="Matrioshka", T matrioshka=default(T))
        {
            _boneca = matrioshka;
            Nombre = name;
        }
        public string Contenido(T m= default(T))
        {
            var contenido = "";
            if (this._boneca != null || m!=null)
            {
                contenido += Contenido(_boneca);
            }
            else
            {
                contenido += this.Nombre;
            }
            return contenido;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrioshka<huevo> M1 = new Matrioshka<huevo>();
            Console.WriteLine(M1.Contenido());
            Console.ReadLine();
        }
    }
}
