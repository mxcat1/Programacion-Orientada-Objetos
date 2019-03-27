using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria_Isur
{
    class Ambiente
    {
        string Nombre { get; set; }
        // Una lista de muebles
        List<Mueble> Mobiliaria { get; set; }
    }
    class Cocina:Ambiente
    {
        List<Utencilio> Utencilios { get; set; }
    }
    class PatioComida : Ambiente
    {

    }
    class Recepcion:Ambiente
    {

    }
    class ServiciosHigienicos:Ambiente
    {

    }
    enum TipoUtencilio
    {
        Nimguno=0, Metal=1,Bronce=1
    }
    class Utencilio
    {
        TipoUtencilio Tipo { get; set; }
    }
    class Platos:Utencilio
    {

    }
    class Ollas : Utencilio
    {

    }
    class Producto
    {
        String Nombre { get; set; }
        DateTime fechaVence { get; set; }

    }
    class Sandwich:Producto
    {

    }
    class Bebidas:Producto
    {

    }
    class Golosinas:Producto
    {

    }
    class Mueble
    {
        //Cada mueble tiene de propiedad Ambiente por que pertenece a un ambinete
       // Ambiente Ambiente { get; set; }
    }
    class Cafeteria
    {
        internal string Nombre { get; set; }
        internal Ambiente[] Ambientes { get; set; }
        
    }

}

namespace Instituto_POO_P2
{
    class Aula
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Aula L4 = new Aula();

            Cafeteria_Isur.Cafeteria C = new Cafeteria_Isur.Cafeteria();
            C.Nombre = "La Cafeta";
            Console.WriteLine(C.Nombre);
        }
    }
}
