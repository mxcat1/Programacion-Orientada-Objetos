// Christian Vilca Apaza
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
    class Edificio
    {
        List<Aula> Aulas { get; set; }
    }
    class Aula
    {
        float[] Color = new float[4];
        List<Mueble> Mobiliaria { get; set; }
        List<Material> Materiales { get; set; }
        List<Luz> Luces { get; set; }
    }
    class Mueble
    {
        String id_Mueble { get; set; }
        TipoMueble Tipo { get; set; }
        NroPatas Patas { get; set; }
    }
    enum TipoMueble
    {
        Ninguno=0,Silla=1,Mesa=2,Tacho=3
    }
    enum NroPatas
    {
        Ninguno=0,Patas4=2
    }
    class Material
    {
        TipoMaterial Tipo { get; set; }
    }
    enum TipoMaterial
    {
        Ninguno=0,Computador=1,Plumon=2,Mota=3,Proyector=4, Pizarra = 5
    }
    class Luz
    {
        String Marca { get; set; }
        TipoLuz TipoLuces { get; set; }
    }
    enum TipoLuz
    {
        Ninguno=0,Fluorecente=1,Bombilla=2,Led=3
    }
    //class Silla:Mueble
    //{

    //}
    //class Mesa : Mueble
    //{

    //}
    //class Pizarra:Mueble
    //{

    //}
    //class Tacho : Mueble
    //{

    //}
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
