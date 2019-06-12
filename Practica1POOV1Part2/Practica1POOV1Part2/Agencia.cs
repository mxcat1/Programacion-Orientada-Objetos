using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1
{
    interface ICliente
    {
        int Clave { get; set; }
        string Nombre { get; set; }
        string Rfc { get; set; }
        string DireccionFiscal { get; set; }
        string Telefono { get; set; }
        string CorreoElectronico { get; set; }


    }
    class Honorarios<T>
    {
        public T Cliente;
        public Honorarios(T Cli)
        {
            Cliente = Cli;
        }
        public static implicit operator Honorarios<T>(T Cli)
        {
            return new Honorarios<T>(Cli);
        }
    }
    abstract class Cliente:ICliente
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Rfc { get; set; }
        public string DireccionFiscal { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        private double Pago;

        public void RegistrarPago(double p)
        {
            this.Pago = p;
        }
    }
    class CliContado:Cliente
    {
        private tipopago TipoPagoCli;
        public void RegistrarTipoPago(tipopago t)
        {
            this.TipoPagoCli = t;
        }
    }
    class CliCredito : Cliente
    {
        public double LimiteCredito { get; set; }
        public DateTime PlazoMaximo { get; set; }
    }
    enum tipopago
    {
        ninguno=0,efectivo=1,cheque=2,transferencia=3
    }
}
