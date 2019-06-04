using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaGenericosPolimorfismoT2
{
    abstract class Vehiculo<L,N>
    {
        public string Marca { get; set; }
        public string Matricula { get; set; }
        public int Kilometraje { get; set; }
        public int CantidadAsientos { get; set; }
        public Tanque TanqueVehiculo;
        public bool EstadoVehiculo { get; set; }
        public Rueda<L,N>[] RuedasVehiculo;
        public Bateria BateriaVehiculo;
        public Motor MotorVehiculo;
        public Vehiculo(string marca,string matricula,int cantillantas,int cantiasientos,int capac)
        {
            TanqueVehiculo = new Tanque(capac);
            Kilometraje = 0;
            EstadoVehiculo = false;
            RuedasVehiculo = new Rueda<L, N>[cantillantas];
        }
        public virtual bool EncenderVehiculo()
        {
            EstadoVehiculo = true;
            return EstadoVehiculo;
        }
        public virtual bool ApagarVehiculo()
        {
            EstadoVehiculo = false;
            return EstadoVehiculo;
        }
        public virtual int KMRecorridos(int kmrecorridos)
        {
            Kilometraje += kmrecorridos;

            return Kilometraje;
        }
        public virtual bool LlenarTanque()
        {
            TanqueVehiculo.EstadoTanque = true;

            return TanqueVehiculo.EstadoTanque;
        }
    }
    class Moto<L, N> : Vehiculo<L, N>
    {
        public Moto(string marca, string matricula, int cantillantas, int cantiasientos, int capac) : base(marca, matricula, cantillantas, cantiasientos, capac)
        {
        }
    }
    class Carro<L, N> : Vehiculo<L, N>
    {
        public Carro(string marca, string matricula, int cantillantas, int cantiasientos, int capac) : base(marca, matricula, cantillantas, cantiasientos, capac)
        {
        }
    }
    class Bus<L, N> : Vehiculo<L, N>
    {
        public Bus(string marca, string matricula, int cantillantas, int cantiasientos, int capac) : base(marca, matricula, cantillantas, cantiasientos, capac)
        {
        }
    }
    class Rueda<L,N>
    {
        public L Llantas;
        public N Neumaticos;

    }
    abstract class Llanta
    {

    }
    class Radiales: Llanta
    {

    }
    class Convencionales: Llanta
    {

    }
    class ParaInvierno: Llanta
    {

    }
    class Bateria
    {

    }
    class Motor
    {

    }
    class Tanque
    {
        public int Capacidad { get; set; }
        public bool EstadoTanque { get; set; }
        public Tanque(int capac)
        {
            EstadoTanque = false;
            Capacidad = capac;
        }
    }
    abstract class Neumatico
    {

    }
    class Diagonales:Neumatico
    {

    }
    class Radios:Neumatico
    {

    }
    class Tubetype : Neumatico
    {

    }
    class Tubeless : Neumatico
    {

    }

}
