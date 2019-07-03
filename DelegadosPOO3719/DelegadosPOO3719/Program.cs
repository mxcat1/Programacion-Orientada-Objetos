using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosPOO3719
{
    public delegate void MiDelegado(string mensaje);
    class Program
    {
        static void Main(string[] args)
        {
            //MiDelegado delegado= Clases.MetodoRadio;
            //delegado("Hola a todos");
            //delegado += Pastel.MostrarPastel;
            //delegado("Feliz Cumpleaños");
            CRefri MiRefri = new CRefri(70, -20);
            Random rnd = new Random();

            //MiRefri.AdicionarMetodoDescongelado(InformeGrados); para el anterior ejemplo
            //MiRefri.AdicionarMetodoReserva(new CRefri.dKilosReservasBajas(InformeKilos)); para el anterior ejemplo

            //CRefri.dDescongelado x = grados => InformeGrados(grados); // para otro momento no entender

            dKilosReservasBajas kilos1 = new dKilosReservasBajas(InformeKilos);
            dKilosReservasBajas kilos2 = new dKilosReservasBajas(CTienda.MandarViveres);

            dDescongelado desc1 = new dDescongelado(InformeGrados);

            MiRefri.AdicionarMetodoReserva(kilos1);
            MiRefri.AdicionarMetodoReserva(kilos2);
            MiRefri.AdicionarMetodoDescongelado(desc1);

            while (MiRefri.KilosAlimento>0)
            {
                MiRefri.Trabajar(rnd.Next(1, 5));
            }


            Console.ReadLine();
        }
        public static void InformeKilos(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Reservas bajas de alimentos estoy a nivel de main");
            Console.WriteLine($"Quedan {pKilos}");
        }
        public static void InformeGrados(int pGrados)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Reservas bajas de alimentos estoy a nivel de main");
            Console.WriteLine($"Estan a {pGrados} Grados");
        }
    }

}
