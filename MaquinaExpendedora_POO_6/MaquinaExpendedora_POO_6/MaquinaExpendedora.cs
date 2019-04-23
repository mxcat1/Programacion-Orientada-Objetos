using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedora_POO_6
{
    class Producto
    {
        public string NomProducto { get; set; }
        public TipoProducto TipPorducto { get; set; }
    }
    enum TipoProducto
    {
        ninguno=0,Bebida=1,Golosinas=2,Etc=3
    }
    class MaquinaExpendedora
    {
        public Bandeja[] BandejasMaquina;
        public MaquinaExpendedora(int CantiBandejas)
        {
            BandejasMaquina = new Bandeja[CantiBandejas];
        }
        public void MostrarProductos()
        {

        }
    }
    class Bandeja
    {
        public CasillaProducto[] CasillasProductoBandeja;
        public Bandeja(int CantidadCasillas)
        {
            CasillasProductoBandeja = new CasillaProducto[CantidadCasillas];
        }
    }
    class CasillaProducto
    {
        public bool CasillaDoble { get; set; }
        public int IdCasilla { get; set; }
        public Producto CsllaProducto { get; set; }
        public float PrecioCasillaProducto { get; set; }
        public int CantiProductos { get; set; }

    }
    class TecladoNumerico
    {
        public int[] NumerosTeclado;
        public TecladoNumerico()
        {
            NumerosTeclado = new int[9];
            for (int i = 0; i <= 9; i++)
            {
                NumerosTeclado[i] = i + 1;
            }
        }
        public int EnviarCodigo()
        {
            int Codigo;
            //Por Ahora es cero
            return Codigo=0;
        }

    }
    interface IPantallaLed<T>
    {
        void MostrarSaldo(Moneda moneda);
    }
    interface IPulsador<T>
    {
        void SacarSaldo(Moneda moneda);
    }
    interface IEntradaDinero<T>
    {
        void RecibirDinero(Moneda moneda);
        void VerificarDinero(Moneda moneda);
    }

    class PanelFrontal:IPantallaLed<PanelFrontal>, IPulsador<PanelFrontal>, IEntradaDinero<PanelFrontal>
    {
        public TecladoNumerico TecladoPF;
        public void MostrarSaldo(Moneda moneda) {
            Console.WriteLine(moneda.TipMoneda+"----"+moneda.ValorMoneda);
        }
        public void SacarSaldo(Moneda moneda)
        {

        }
        public void RecibirDinero(Moneda moneda)
        {

        }
        public void VerificarDinero(Moneda moneda)
        {

        }
    }
    interface Despachador<T>
    {
        void CalcularVuelto(Moneda moneda,CasillaProducto casillaProducto);
        void EntregarVuelto(Moneda moneda);
    }
    class DespachadorVuelto:Despachador<DespachadorVuelto>
    {
        public Moneda monedaVuelto { get; set; }
        public void CalcularVuelto(Moneda moneda, CasillaProducto casillaProducto)
        {

        }
        public void EntregarVuelto(Moneda moneda)
        {

        }
    }
    class Compartimiento
    {

    }
    class CompartimientoVuelto : Compartimiento
    {

    }
    class CompartimientoDinero : Compartimiento
    {

    }

    class Moneda
    {
        public TipoMoneda TipMoneda { get; set; }
        public float ValorMoneda { get; set; }
    }
    enum TipoMoneda
    {
        ninguna=0,Soles=1,Dolares=2
    }

}
