using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaGenericosPolimorfismoT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Los datos del Jugador \n Nombre \n Peso \n Estatura \n Fecha de Nacimiento \n Nombre del Equipo");
            string nom = Console.ReadLine();
            float peso = float.Parse(Console.ReadLine());
            float estatura = float.Parse(Console.ReadLine());
            string fecha = Console.ReadLine();
            DateTime fechanac = DateTime.Parse(fecha);
            EquipoNacional RealMadrid = "Club Real Madrid";
            Portero <EquipoNacional> P= new Portero<EquipoNacional>(nom, peso, estatura, fechanac, RealMadrid);
            Console.WriteLine(P.EquipoFutbolista.NombreEquipo);
            Console.WriteLine(P.EdadDeportista);
            Console.WriteLine(P.ResistenciaDeportista);
            Console.WriteLine(P.TecnicaFutbolista);
            Console.WriteLine(P.VelocidadFutbolista);
            Console.WriteLine(P.ValorNetoFutbolista);
            Console.WriteLine("Aplicando entrenamineto normal");
            P.Entrenamiento(5,TipoEntrenamiento.Aerobico);
            Console.WriteLine(P.ResistenciaDeportista);
            Console.WriteLine(P.TecnicaFutbolista);
            Console.WriteLine(P.VelocidadFutbolista);
            Console.WriteLine(P.ValorNetoFutbolista);
            Console.ReadLine();
        }
    }
}
