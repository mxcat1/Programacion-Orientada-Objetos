using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Damas_Chinas_POO_CV5
{
    class Partida
    {
        public string PartidaEstado { get; set; }
        public int NroPartida { get; set; }
        public Jugador[] JugadoresPartida;

        public void IniciarPartida(int cantidadJugadores) {
            if (cantidadJugadores > 1 && cantidadJugadores<6)
            {
                JugadoresPartida = new Jugador[cantidadJugadores];
                for (int i =0; i < cantidadJugadores; i++)
                {
                    Color colorjuga = new Color();
                    JugadoresPartida[i] = new Jugador("Jugador"+i+1,colorjuga);
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

    }
    class Jugador {
        public int IdJugador { get; set; }
        public string NickName { get; set; }
        public Ficha[] FichasJugador;
        public Jugador(String Nick,Color colorjugadorficha)
        {
            NickName = Nick;
            generarId();
            FichasJugador = new Ficha[10];
            for (int i = 0; i < 10; i++)
            {
                Coordenada cordenadas = new Coordenada();
                FichasJugador[i] = new Ficha(colorjugadorficha,cordenadas);
            }
        }
        public void generarId()
        {
            Random raw = new Random();
            IdJugador = raw.Next(0, 100);
        }
    }
    class Coordenada
    {
        public int x { get; set; }
        public int y { get; set; }
    }
    class Ficha
    {
        public Color ColorFicha { get; set; }
        public Coordenada Posicion { get; set; }
        public Ficha(Color fichacolor,Coordenada coordenada)
        {
            ColorFicha = fichacolor;
            Posicion = coordenada;
        }
        public void Mover() {

        }
    }
    class Tablero
    {
        public Casillas[] CasillerosTablero;
    }
    class Casillas
    {
        public Coordenada Posicion { get; set; }
    }
}
