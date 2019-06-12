using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta2
{
    class Cliente<T>
    {
        public string ClaveCli { get; set; }
        public string NombreCli { get; set; }
        private T Cuenta;

        public Cliente(string clave,string nombre,T cuenta)
        {
            this.ClaveCli = clave;
            this.NombreCli = nombre;
            this.Cuenta = cuenta;
        }

    }
    interface ICuenta
    {
        double NCuenta { get; set; }
        double SaldoCuenta { get; set; }
        string ConsultarDatos();
        double Depositar();
        string Retirar();
    }
    abstract class Cuenta:ICuenta
    {
        protected double _NCuenta;
        protected double _SaldoCuenta;

        public double NCuenta { get => _NCuenta; set => _NCuenta=value; }
        public double SaldoCuenta { get => _SaldoCuenta; set => _SaldoCuenta=value; }

        public string ConsultarDatos()
        {
            throw new NotImplementedException();
        }

        public double Depositar()
        {
            throw new NotImplementedException();
        }

        public virtual string Retirar()
        {
            throw new NotImplementedException();
        }
    }
    class CuentaCheques:Cuenta
    {
        public double ComisionUsoChequera { get; set; }
        public double ComisionEmisionChequera { get; set; }


    }
    class CuentaAhorros:Cuenta
    {
        public DateTime FecVec { get; set; }
        public double InteresMensual { get; set; }
        private void DepoInt()
        {

        }
        public override string Retirar()
        {

            if (DateTime.Now == FecVec)
            {
                return "Se Retiro con Exito";
            }

            return "No se Puede Retirar Por la Fecha";
        }
    }
}
