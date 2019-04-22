using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Constructora_POO4_C
{
    // public abstract class UnidadHabitacional{

    // }
    public class Dimencionm2{
        //Solo Terreno Regular
        public float Ancho{get;set;}
        public float Largo{get;set;}
        public float Area{get;set;}
        public void CalcularArea(){
            Area=Ancho*Largo;
        }
    }
    public enum TipoHabitacion{
        ninguna=0,Baño=1,Cuarto=2,Comedor=3
    }
    public class Habitacion:Piso{
        public TipoHabitacion TipoHabitacion {get;set;}
    }
    public class Piso{
        public Dimencionm2 DimecionPisoHabitacion{get;set;}
        public float AlturaPisoHabitacion{get;set;}
    }
    public class Edificio{
        // UnidadHabitacional[][] _UnidadHabitaciolaEdificio;
        // UnidadHabitacional[] _Habitaciones;
        Piso[][] PisosEdificios;
        public Edificio( int nroPiso=1){
            PisosEdificios=new Piso[nroPiso][];
            // _UnidadHabitaciolaEdificio[0]= new Piso[nroPiso][];
            
        }
        public void DefinirHabitaciones(int nPiso,int nHabitaciones){
            PisosEdificios[nPiso]=new Habitacion[nHabitaciones];
            // _Habitaciones=new Habitacion[nHabitaciones];
            // _Pisos[nPiso]=new Habitacion[nHabitaciones];
            // for (int i=0;i<nHabitaciones;i++){
            //     _Pisos[nPiso][i]=new Habitacion[nHabitaciones];
            // }

        }
        public void AgregarHabitaciones(int nPiso,int nHabitaciones){
            for (int i=0;i<nHabitaciones;i++){
                PisosEdificios[nPiso][i]=new Habitacion();
            }
        }        
    }

}
