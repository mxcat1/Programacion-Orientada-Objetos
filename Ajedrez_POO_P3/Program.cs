using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez_POO_P3
{
    abstract class Pieza{
        public Casilla UbiCasilla{get;set;}
        public float[] ColorPieza = new float[3];
        

    }
    class Peon:Pieza{
        //Aca Tambien iria sus reglas para cada Pieza
    }
    class Torre:Pieza{
        //Aca Tambien iria sus reglas para cada Pieza
    }
    class Reina:Pieza{
        //Aca Tambien iria sus reglas para cada Pieza
    }
    class Alfil:Pieza{
        //Aca Tambien iria sus reglas para cada Pieza
    }
    class Caballo:Pieza{
        //Aca Tambien iria sus reglas para cada Pieza
    }
    class Rey:Pieza{
        //Aca Tambien iria sus reglas para cada Pieza
    }
    class Jugador{
        public String NombreJugador{get;set;}
        public Peon[] JugadorPeon=new Peon[8];
        public Rey JugadorRey{get;set;}
        public Reina JugaroReina{get;set;}
        public Caballo[] JugadorCaballo = new Caballo[2];
        public Alfil[] JugadorAlfil = new Alfil[2];
        public Torre[] JugadorTorre = new Torre[2];
        //  private Partida _JugadorPartida;

        //Cualquier Jugador inicia un partida
        public void CrearPartida(){
             Partida JugadorPartida = new Partida();
        }

    }
    class Partida{
        public Reloj TiempoInicio{get;set;}
        public Reloj TiempoFinal{get;set;}
        public Reloj TiempoMax{get;set;}
        public TipoPartida TipoPartidaJugada{get;set;}
        public Jugador Jugador1{get;set;}
        public Jugador Jugador2{get;set;}

    }
    enum TipoPartida{
        Ninguna=0,PartidaBlitz=1,PartidaRápida=2,PartidaEstándar=3
    }
    class Tablero{
        // Eltablero tiene 64 casillas
        public Casilla[] CasillaTablero=new Casilla[64];
    }
    class Casilla{
        public int Fila{get;set;}
        public string Columna {get;set;}
    }
    class Reloj{

    }
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Hello World!");
        }
    }
}
