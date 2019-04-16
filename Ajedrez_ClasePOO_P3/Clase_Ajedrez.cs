using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Ajedrez
{
    public class Coordenada{
        public int x;public int y;
    }
    public class Pieza{

        public Color ColorPieza{get;set;}
        public bool Activo{get;set;}
        public bool PuedeAscender{get;set;}
        public Coordenada Posicion {get;set;}
        //------------- Metodos
        public void Mover(){

        }
        public void Matar(){

        }
    }
    public class Peon:Pieza{

    }
    public class Caballo:Pieza{
        
    }
    public class Alfil:Pieza{
        
    }
    public class Rey:Pieza{
        
    }
    public class Reina:Pieza{
        
    }
    public class Torre:Pieza{
        
    }
    class Persona{

    }
    class Jugador:Persona{

    }
    class Casillero{

    }
    class Tablero{
        Casillero[,] TableroCasillero;
        public Tablero(){

        }
    }
    class JuegoAjedrez{
        Tablero TableroJuegoAjedrez {get;set;}
        Jugador[] _Jugadores;

        public JuegoAjedrez(){
            _Jugadores = new Jugador();
        }
    }

}
