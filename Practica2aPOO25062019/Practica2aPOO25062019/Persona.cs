using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2aPOO25062019
{
    class Persona
    {
        private Categoria _categoria;
        private Domicilio _domicilio = new Domicilio();
        public Persona(Categoria Cate=null)
        {
            _categoria = Cate;
        }
        public string postularsucursal()
        {
            return Postulacion.postular();
        }

    }
    class Categoria
    {

    }
    class Domicilio
    {

    }
    class TiempoEnSucursal
    {
        private Persona _persona;
        private Sucursal _sucursal;
        public TiempoEnSucursal(Persona persona=null,Sucursal sucursal=null)
        {
            _persona = persona;
            _sucursal = sucursal;
        }
    }
    class Sucursal
    {

    }
    class Postulacion
    {
        public static string postular()
        {
            return "Postulando";
        }
    }
}
