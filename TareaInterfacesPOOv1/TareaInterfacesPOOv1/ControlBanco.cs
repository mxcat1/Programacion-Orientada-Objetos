using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaInterfacesPOOv1
{
    public interface IDesplegable
    {
        string MostrarDatos();
        string ToString();
    }
    public interface IFecha<T>
    {
        DateTime Fecha
        {
            get;
            set;
        }
        string FechaConLetra();
        string PruebaFecha(T fechas);
    }
    class Factura:IDesplegable,IFecha<DateTime>
    {
        private int _intFolio;
        private string _strCliente;
        private double _dlbTotal;
        private DateTime _dtmFecha;

        public int Folio
        {
            get { return _intFolio; }
            set { _intFolio = value; }
        }
        public string Cliente
        {
            get { return _strCliente; }
            set { _strCliente = value; }
        }
        public double Total
        {
            get { return _dlbTotal; }
            set { _dlbTotal = value; }
        }
        public DateTime Fecha
        {
            get { return _dtmFecha; }
            set { _dtmFecha = value; }
        }
        public string FechaConLetra()
        {
            DateTimeFormatInfo dtmont = new DateTimeFormatInfo();
            
            return $"{Fecha.Day} de {dtmont.GetMonthName(Fecha.Month)} del {Fecha.Year}"; ;
        }
        public string MostrarDatos()
        {
            string Datos = $"El Folio es {Folio} \n El Cliente es {Cliente} \n El Total es {Total} \n La Fecha es {Fecha}";
            return Datos;
        }
        public string PruebaFecha(DateTime f)
        {
            return f.ToString();
        }
        public override string ToString()
        {
            return $"{Folio}\n{Cliente}\n{Total}\n{Fecha}";
        }

    }
    class CuentaBancaria:IDesplegable,IFecha<DateTime>
    {
        private int _intNumero;
        private double _dlbSaldo;
        private DateTime _dtmFechaApertura;

        public int Numero
        {
            get { return _intNumero; }
            set { _intNumero = value; }
        }
        public double Saldo
        {
            get { return _dlbSaldo; }
            set { _dlbSaldo = value; }
        }
        public DateTime Fecha
        {
            get { return _dtmFechaApertura; }
            set { _dtmFechaApertura = value; }
        }
        public string FechaConLetra()
        {
            DateTimeFormatInfo dtmont = new DateTimeFormatInfo();

            return $"{Fecha.Day} de {dtmont.GetMonthName(Fecha.Month)} del {Fecha.Year}"; ;
        }
        public string MostrarDatos()
        {
            string Datos = $"El Numero es {Numero} \n El Saldo es {Saldo} \n La Fecha es {Fecha}";
            return Datos;
        }
        public string PruebaFecha(DateTime f)
        {
            return f.ToString();
        }
        public override string ToString()
        {
            return $"{Numero}\n{Saldo}\n{Fecha}";
        }
    }
}
