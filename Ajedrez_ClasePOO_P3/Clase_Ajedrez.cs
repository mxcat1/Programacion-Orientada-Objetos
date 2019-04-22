using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Ajedrez
{
    public class Coordenada{
        public string x;public int y;
    }
    public class Pieza{

        public Color ColorPieza{get;set;}
        public bool Activo{get;set;}
        // public bool PuedeAscender{get;set;}
        public Coordenada Posicion {get;set;}
        //------------- Metodos
        public void Mover(){

        }
        public void Matar(){

        }
    }
    public enum TipoPieza{
        ninguna=0,Caballo=1
    }
    public class Peon:Pieza{
        public bool PuedeAscender{get;set;}
        //Error creo q se debe crear una funcion para cada uno de las ascenciones
        public void AscenderPeon(Peon PeonJuego,TipoPieza PiezaAConvertir){
            PeonJuego = (PiezaAConvertir)PeonJuego;
        }
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
    // class Persona{

    // }
    class Jugador{
        public int IdJugador{get;set;}
        public string NickName{get;set;}
        public Peon[] PeonJugador;
        public Reina ReinaJugador;
        public Rey ReyJugador;


    }
    class Casillero{
        public string Vertical{get;set;}
        public int Horizontal{get;set;}
    }
    class Tablero{
        Casillero[,] TableroCasillero;
        public Tablero(){
            TableroCasillero = new Casillero[8,8];
        }
    }
    class JuegoAjedrez{
        Tablero TableroJuegoAjedrez {get;set;}
        Jugador[] _Jugadores;

        public JuegoAjedrez(int CantidadJugadores){
            _Jugadores = new Jugador[CantidadJugadores];
        }
    }

}
