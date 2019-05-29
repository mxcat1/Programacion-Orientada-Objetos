using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AjedrezPOO_AgregadoPolimorfismo
{
    public class Coordenada
    {
        public string x; public int y;
    }
    public class Pieza
    {

        public Color ColorPieza { get; set; }
        public bool Activo { get; set; }
        // public bool PuedeAscender{get;set;}
        public Coordenada Posicion { get; set; }
        //------------- Metodos
        // con el metodo virtual para poder sobreescribir
        public virtual void Mover()
        {

        }
        public virtual void Matar()
        {

        }
    }
    public enum TipoPieza
    {
        ninguna = 0, Caballo = 1
    }

    public class Peon : Pieza
    {
        public bool PuedeAscender { get; set; }
        //Metodo mover q se sobreescribio
        public override void Mover()
        {
            base.Mover();
        }
    }
    public class Caballo : Pieza
    {
        public override void Mover()
        {
            base.Mover();
        }
    }
    public class Alfil : Pieza
    {
        public override void Mover()
        {
            base.Mover();
        }
    }
    public class Rey : Pieza
    {
        public override void Mover()
        {
            base.Mover();
        }
    }
    public class Reina : Pieza
    {
        public override void Mover()
        {
            base.Mover();
        }
    }
    public class Torre : Pieza
    {
        public override void Mover()
        {
            base.Mover();
        }
    }
    // class Persona{

    // }
    class Jugador
    {
        public int IdJugador { get; set; }
        public string NickName { get; set; }
        public Peon[] PeonJugador;
        public Reina ReinaJugador;
        public Rey ReyJugador;


    }
    class Casillero
    {
        public string Vertical { get; set; }
        public int Horizontal { get; set; }
    }
    class Tablero
    {
        Casillero[,] TableroCasillero;
        public Tablero()
        {
            TableroCasillero = new Casillero[8, 8];
        }
    }
    class JuegoAjedrez
    {
        Tablero TableroJuegoAjedrez { get; set; }
        Jugador[] _Jugadores;

        public JuegoAjedrez(int CantidadJugadores)
        {
            _Jugadores = new Jugador[CantidadJugadores];
        }
    }

}
