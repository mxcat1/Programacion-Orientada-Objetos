using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPOOClaseP2
{
    class Estudiante : IComparable<Estudiante>
    {
        public int codigo { get; set; }
        public int CompareTo(Estudiante E1)
        {

            //var dato=(this.codigo == E1.codigo) ? 0:(this.codigo<E1.codigo)? -1: 1;
            return this.codigo.CompareTo(E1.codigo);
        }
    }
    class Alumno<T> : IComparable<T>
    {
        string Codigo { get; set; }
        public Alumno(string codigo = "")
        {
            this.Codigo = codigo;
        }
        public static implicit operator Alumno<T>(T i)
        {
            return new Alumno<T>(i.ToString());
        }
        public int CompareTo(T obj)
        {

            Alumno<T> nalumno = obj;
            return (nalumno.Codigo == this.Codigo) ? 0 : 1;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Alumno<double> a1 = new Alumno<double>("1.6");
            Console.WriteLine(a1.CompareTo(1.6));
            Console.ReadLine();
        }
    }
}
