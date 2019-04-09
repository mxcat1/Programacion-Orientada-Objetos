using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Pregunta1_Examen1

namespace Biblioteca_Isur
{
    class Persona{
        public string NomPersona{get;set;}
        public string ApePersona{get;set;}
    }
    class Cliente:Persona{

    }
    class Autor:Persona{
        //Un Autor Puede tener varios Libros
        public List<Libro> ListaLibros {get;set;}
        public Autor(){
            ListaLibros = new List<Libro>();
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


    class Libro{
        //un Libro puede tener uno o mas Autores
        public List<Autor> Autores {get;set;}
        public Editorial EditorialLibro {get;set;}
        public Libro(){
            Autores = new List<Autor>();
        }
    }
    class Editorial{

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
