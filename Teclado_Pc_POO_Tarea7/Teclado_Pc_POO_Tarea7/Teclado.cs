using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teclado_Pc_POO_Tarea7
{
    public class Teclado
    {
        Bloque[] Bloques;
        TipoTeclado _tipoTeclado;
        Led[] Leds;

        public Bloque[] bloques
        {
            get { return Bloques; }
            set { Bloques = value; }
        }
        public TipoTeclado tipoTeclado
        {
            get { return _tipoTeclado; }
            set { _tipoTeclado = value; }
        }
        public Teclado(int cantBloques,TipoTeclado tipoTeclado)
        {
            if(cantBloques>0 && cantBloques < 7)
            {
                Bloques = new Bloque[cantBloques];
                _tipoTeclado = tipoTeclado;
                Leds = new Led[3];
            }
        }
        public void ingresarBloques(int bloque,TipoBloque tipo,string nombloque,int cantiteclas)
        {
            bloques[bloque] = new Bloque(tipo,nombloque,cantiteclas);
        }

    }
    public class Tecla
    {
        object[] ValorTecla;

        public object[] valorTecla
        {
            get { return ValorTecla; }
            set { ValorTecla = value; }
        }

        public Tecla(int cantiValores)
        {
            ValorTecla = new string[cantiValores];

        }
    }
    public class Led
    {
        TipoLed _TipoLed;

        public TipoLed tipoLed
        {
            get { return _TipoLed; }
            set { _TipoLed = value; }
        }
        public Led(TipoLed tipo)
        {
            _TipoLed = tipo;
        }

    }
    public class Bloque
    {
        TipoBloque _tipoBloque;
        string NomBloque;
        Tecla[] ConjuntoTeclas;

        public TipoBloque tipoBloque
        {
            get { return _tipoBloque; }
            set { _tipoBloque = value; }
        }
        public string _nomBloque
        {
            get { return NomBloque; }
            set { NomBloque = value; }
        }

        public Tecla[] conjuntoTeclas
        {
            get { return ConjuntoTeclas; }
            set { ConjuntoTeclas = value; }
        }

        public Bloque(TipoBloque tipo,string nombloque,int cantiTeclas)
        {
            _tipoBloque = tipo;
            NomBloque = nombloque;
            ConjuntoTeclas = new Tecla[cantiTeclas];
        }
        public void AsignarTeclas(int tecla,params string[] valorestecla)
        {
            ConjuntoTeclas[tecla] = new Tecla(valorestecla.Length);
            ConjuntoTeclas[tecla].valorTecla = valorestecla;
        }

    }
    public enum TipoBloque
    {
        ninguno=0, BloqueFunciones=1, BloqueAlfanumérico=2, BloqueEspecial=3, BloqueNumérico=4, BloqueMultimedia=5
    }
    public enum TipoTeclado
    {
        ninguno=0,Ergonomico=1,Multimedia=2,Flexible=3,DeMembrana=4,Mecanicos=5
    }
    public enum TipoLed
    {
        ninguno=0,num=1,caps=2,scroll=3
    }
}
