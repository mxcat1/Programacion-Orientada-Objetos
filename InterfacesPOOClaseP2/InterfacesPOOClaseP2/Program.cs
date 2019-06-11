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
    class Alumno : IComparable
    {
        string Codigo { get; set; }
        public Alumno(string codigo = "")
        {
            this.Codigo = codigo;
        }
        //public static implicit operator Alumno(object i)
        //{
        //    return new Alumno(i.ToString());
        //}
        //public int CompareTo(object obj)
        //{

        //    Alumno nalumno = obj;

        //}
        public int CompareTo(object obj)
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
