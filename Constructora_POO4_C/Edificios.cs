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
    public class Habitacion:Piso{
    }
    public class Piso{

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
        public void AgregarHabitaciones(){
            
        }        
    }

}
