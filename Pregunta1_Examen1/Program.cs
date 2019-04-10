using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Pregunta1_Examen1

namespace Biblioteca_Isur
{
    class Biblioteca{
        // Agregacion
        public Producto Producto_Biblio{get;set;}
        //COmposicion
        public Autor AutorP1=new Autor();
        //Agregacion
        public void Prestamos(Producto Producto_Biblio){
            Console.WriteLine("Hola");
        }
        public void Sanciones(){
            Console.WriteLine("Hola");
        }
        public void EntradaProducto(Autor AutorP1){
            Console.WriteLine("Hola");
        }
        public void Restauraciones(){
            Console.WriteLine("Hola");
        }
    }

    class Persona{
        public string NomPersona{get;set;}
        public string ApePersona{get;set;}
    }
    class Cliente:Persona{

    }
    class Autor:Persona{
        //Un Autor Puede tener varios Libros,Revistas ETC
        // Se cambio la lista de plibros por la de productos
        public List<Producto> ListaProductos {get;set;}
        public Autor(){
            ListaProductos = new List<Producto>();
        }
    }
    class Adminstrador:Persona{
        // Un Administrador puede tener un cargo mayor por ende puede tener 
        // Subordinados o trabajadores a su cargo
        public Cargo AdminCargo{get;set;}
        public List<Adminstrador> AdminsACargo{get;set;}
        public Adminstrador(Cargo CargoAdmin=Cargo.Ninguno){
            AdminCargo=CargoAdmin;
            if(AdminCargo==Cargo.Gerente){
                AdminsACargo=new List<Adminstrador>();
            }
        }

    }
    enum Cargo{
        Ninguno=0,Gerente=1,Encargado=2
    }
    class Producto{
        public string NombrePro {get;set;}
        public TipoProducto ProductoTipo {get;set;}
        public List<Autor> Autores {get;set;}
        public Editorial EditorialLibro {get;set;}
        public Producto(){
            Autores = new List<Autor>();
        }

    }
    // se cambio la clse libro por producto donde se lleva 
    // revistas periodicos etc
    // se agrego la clse enum para poder aumentar
    enum TipoProducto{
        Ninguno=0,Libro=1,Revistas=2,Periodico=3,etc=5
    }

/*     class Libro:Producto{
        //un Libro puede tener uno o mas Autores
        public List<Autor> Autores {get;set;}
        public Editorial EditorialLibro {get;set;}
        public Libro(){
            Autores = new List<Autor>();
        }
    } */
    class Editorial{

    }
/*     class Operaciones{
        public void Prestamos{

        }
        public void Sanciones{

        }
        public void EntradaProducto{

        }
        public void Restauraciones{

        }
    } */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Biblioteca Biblio_1=new Biblioteca();
            Biblio_1.Sanciones();
        }
    }
}
