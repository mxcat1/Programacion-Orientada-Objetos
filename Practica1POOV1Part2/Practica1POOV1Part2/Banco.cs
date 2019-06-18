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
        public override string ToString()
        {
            return NombreCli;
        }

    }
    interface ICuenta
    {
        double NCuenta { get; set; }
        float SaldoCuenta { get; set; }
        string ConsultarDatos();
        float Depositar(float canti);
        string Retirar(float retiro);
    }
    abstract class Cuenta:ICuenta
    {
        protected double _NCuenta;
        protected float _SaldoCuenta;

        public double NCuenta { get => _NCuenta; set => _NCuenta=value; }
        public float SaldoCuenta { get => _SaldoCuenta; set => _SaldoCuenta=value; }

        public string ConsultarDatos()
        {
            return $" {this.NCuenta} ";
        }

        public float Depositar(float canti)
        {

            this.SaldoCuenta += canti;
            return this.SaldoCuenta;
        }

        public virtual string Retirar(float retirar)
        {
            this.SaldoCuenta -= retirar;
            return this.SaldoCuenta.ToString();
        }
        public override string ToString()
        {
            return NCuenta.ToString();
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
        public override string Retirar(float retirar)
        {

            if (DateTime.Now == FecVec)
            {
                return "Se Retiro con Exito";
            }

            return "No se Puede Retirar Por la Fecha";
        }
    }
}
