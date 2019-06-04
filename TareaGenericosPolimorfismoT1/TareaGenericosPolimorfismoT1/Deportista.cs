using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaGenericosPolimorfismoT1
{
    abstract class Deportista
    {
        public string NombreDeportista { get; set; }
        public DateTime FechaNacDeportista { get; set; }
        public float EdadDeportista { get; }
        public float ResistenciaDeportista { get; set; }
        public float PesoDeportista { get; set; }
        public float EstaturaDeportista { get; set; }
        public Deportista(string nombres,float peso,float estatura,DateTime fecnac)
        {
            NombreDeportista = nombres;
            FechaNacDeportista = fecnac;
            EdadDeportista = (int)(DateTime.Now.Year - fecnac.Year);
            ResistenciaDeportista = ((EdadDeportista / 20) * 100)-EdadDeportista;
            PesoDeportista = peso;
            EstaturaDeportista=estatura;
        }
        public virtual float Entrenamiento(float horasentrena,TipoEntrenamiento TE)
        {
            float potenciador = 0;
            switch (TE)
            {
                case TipoEntrenamiento.Normal:
                    potenciador = 1;
                    break;
                case TipoEntrenamiento.Aerobico:
                    potenciador = 1.5F;
                    break;
                case TipoEntrenamiento.Anaerobico:
                    potenciador = 2;
                    break;
                case TipoEntrenamiento.Potencia:
                    potenciador = 1.8F;
                    break;
                case TipoEntrenamiento.Velocidad:
                    potenciador = 2;
                    break;
                case TipoEntrenamiento.Fuerza:
                    potenciador = 2.5F;
                    break;

            }
            float gananciaR = (horasentrena / 10)*potenciador;
            ResistenciaDeportista += gananciaR;
            return gananciaR;
        }

    }
    public enum TipoEntrenamiento
    {
        Normal = 0, Aerobico = 1, Anaerobico = 2, Potencia = 3, Velocidad = 4, Fuerza = 5
    }
    class Futbolista<T> : Deportista
    {

        public float TecnicaFutbolista { get; set; }
        public float VelocidadFutbolista { get; set; }
        public float ValorNetoFutbolista { get; set; }
        public T EquipoFutbolista;
        public Futbolista(string nombres, float peso, float estatura, DateTime fecnac,T nomequipo) : base(nombres, peso, estatura, fecnac)
        {
            EquipoFutbolista = nomequipo;
            TecnicaFutbolista = ((EdadDeportista / 19) * 100) - EdadDeportista;
            VelocidadFutbolista = (((EdadDeportista / 15) * 100) - EdadDeportista)-(peso*1.3F);
            ValorNetoFutbolista = (ResistenciaDeportista + TecnicaFutbolista + VelocidadFutbolista) * 0.1F;
        }
        public void CambioEquipo(T nomequipo)
        {
            EquipoFutbolista = nomequipo;
        }

        public override float Entrenamiento(float horasentrena,TipoEntrenamiento TE)
        {
            float potenciador = 0;
            float ganancia=0;
            switch (TE)
            {
                case TipoEntrenamiento.Normal:
                    potenciador = 1.1F;
                    ganancia = (horasentrena / 15) * potenciador;
                    ResistenciaDeportista += ganancia;
                    TecnicaFutbolista += ganancia*0.4F;
                    VelocidadFutbolista += ganancia * 0.5F;
                    break;
                case TipoEntrenamiento.Aerobico:
                    potenciador = 1.7F;
                    ganancia = (horasentrena / 15) * potenciador;
                    ResistenciaDeportista += ganancia;
                    TecnicaFutbolista += ganancia * 0.5F;
                    VelocidadFutbolista += ganancia * 0.6F;
                    break;
                case TipoEntrenamiento.Anaerobico:
                    potenciador = 2.2F;
                    ganancia = (horasentrena / 15) * potenciador;
                    ResistenciaDeportista += ganancia;
                    TecnicaFutbolista += ganancia * 0.6F;
                    VelocidadFutbolista += ganancia * 0.7F;
                    break;
                case TipoEntrenamiento.Potencia:
                    potenciador = 1.5F;
                    ganancia = (horasentrena / 15) * potenciador;
                    ResistenciaDeportista += ganancia;
                    TecnicaFutbolista += ganancia * 0.8F;
                    VelocidadFutbolista += ganancia * 0.7F;
                    break;
                case TipoEntrenamiento.Velocidad:
                    potenciador = 2;
                    ganancia = (horasentrena / 15) * potenciador;
                    ResistenciaDeportista += ganancia;
                    TecnicaFutbolista += ganancia * 0.6F;
                    VelocidadFutbolista += ganancia * 0.9F;
                    break;
                case TipoEntrenamiento.Fuerza:
                    potenciador = 2.2F;
                    ganancia = (horasentrena / 15) * potenciador;
                    ResistenciaDeportista += ganancia;
                    TecnicaFutbolista += ganancia * 0.5F;
                    VelocidadFutbolista += ganancia * 0.4F;
                    break;

            }

            return ganancia;
        }


    }
    class Portero<T> : Futbolista<T>
    {
        public Portero(string nombres, float peso, float estatura, DateTime fecnac, T nomequipo) : base(nombres, peso, estatura, fecnac, nomequipo)
        {
        }
    }
    class Delantero<T> : Futbolista<T>
    {
        public Delantero(string nombres, float peso, float estatura, DateTime fecnac, T nomequipo) : base(nombres, peso, estatura, fecnac, nomequipo)
        {
        }
    }
    abstract class Equipo
    {
        public string NombreEquipo { get; set; }
        public Equipo(string nomequipo)
        {
            NombreEquipo = nomequipo;
        }

    }
    class ClubInternacional : Equipo
    {
        public ClubInternacional(string nomequipo) : base(nomequipo)
        {
        }
        public static implicit operator ClubInternacional(string nomequipo)
        {
            return new ClubInternacional(nomequipo);
        }
    }
    class EquipoNacional : Equipo
    {
        public EquipoNacional(string nomequipo) : base(nomequipo)
        {
        }
        public static implicit operator EquipoNacional(string nomequipo)
        {
            return new EquipoNacional(nomequipo);
        }
    }
    class ClubNacional : Equipo
    {
        public ClubNacional(string nomequipo) : base(nomequipo)
        {
        }
        public static implicit operator ClubNacional(string nomequipo)
        {
            return new ClubNacional(nomequipo);
        }
    }
    //Solo Completado hasta futbolista portero y Delantero
    class Patinador : Deportista
    {
        public Patinador(string nombres, float peso, float estatura, DateTime fecnac) : base(nombres, peso, estatura, fecnac)
        {
        }
    }
    class Artistico : Patinador
    {
        public Artistico(string nombres, float peso, float estatura, DateTime fecnac) : base(nombres, peso, estatura, fecnac)
        {
        }
    }

}
