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
        public string Nombre { get; set; }
        public Ambiente[] Ambientes { get; set; }
        List<Mueble> Mobiliaria {get;set;}
        public string Prueba{get;set;}
        
        // Constructor creado con parametros opcionales  y que puede estar en desorden 
        public Cafeteria(string nombre="La Cafeta",string prueba="Hola"){
            Nombre=nombre;
            Prueba=prueba;
            Mobiliaria=new List<Mueble>();
        }
        
    }

}
// ESPACIO DE TRABAJO DE INSTITUTO
// CHRISTIAN VILCA APAZA
// CLASE AULA
namespace Instituto_POO_P2
{
    class Edificio
    {
        public List<Aula> Aulas { get; set; }
    }
    class Piso
    {
        public Byte NroPiso { get; set; }
        public List<Aula> ListaAulas { get; set; }
    }
    class Aula
    {
        public string IdAula { get; set; }
        public float[] Color = new float[4];
        public List<Mueble> Mobiliaria { get; set; }
        public List<Material> Materiales { get; set; }
        public List<Luz> Luces { get; set; }
        public Aula(){
            Mobiliaria = new List<Mueble>();
        }
    }
    class Mueble
    {
        public String Id_Mueble { get; set; }
        public TipoMueble Tipo { get; set; }
        public NroPatas Patas { get; set; }
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
        public TipoMaterial Tipo { get; set; }
    }
    enum TipoMaterial
    {
        Ninguno=0,Computador=1,Plumon=2,Mota=3,Proyector=4, Pizarra = 5
    }
    class Luz
    {
        public String Marca { get; set; }
        public TipoLuz TipoLuces { get; set; }
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

/*             Codigo para instanciar muebles y crear la lista de muebles para aula */
            L4.IdAula = "104B";
            Mueble M1 = new Mueble();
            M1.Id_Mueble = "M1L4";
            M1.Tipo = TipoMueble.Silla;
            M1.Patas = NroPatas.Patas4;
/*             L4.Mobiliaria = new List<Mueble>(); */
            L4.Mobiliaria.Add(M1);
//          Prueba de sobrecarga con solo un parametro y en desorden
            Cafeteria_Isur.Cafeteria C = new Cafeteria_Isur.Cafeteria(prueba: "hola2");

/*             C.Nombre = "La Cafeta"; */            
            Console.WriteLine(C.Nombre+" " + C.Prueba);

/*             Codigo para Mostrar los muebles de la aula */
            Console.WriteLine(L4.IdAula);
            foreach(Mueble muebles in L4.Mobiliaria)
            {
               Console.WriteLine(muebles.Tipo);
               Console.WriteLine(muebles.Id_Mueble);
               Console.WriteLine(muebles.Patas);
            }

            Console.ReadLine();
        }
    }
}
