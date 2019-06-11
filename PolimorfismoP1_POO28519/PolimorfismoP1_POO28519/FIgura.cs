using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoP1_POO28519
{
    interface Icuadrado
    {
        double Lado
        {
            get;set;
        }
    }
    interface IFiguraOperaciones
    {
        double CalcularArea();
        double CalcularPerimetro();
    }
    class Figura
    {
        public double area;
        public virtual double _CalcularArea()
        {
            return area;
        }
        public virtual void DibujarFigura()
        {
            Console.WriteLine("hola");
        }
    }
    class Cuadrado : Figura, Icuadrado, IFiguraOperaciones
    {
        double _dblLado;
        public double Lado { get => _dblLado; set => _dblLado=value; }

        public double CalcularPerimetro()
        {
            return Lado*4;
        }
        public double CalcularArea()
        {
            return Lado * Lado;
        }
    }
    class Rectangulo : Figura
    {
        protected double largo;
        protected double ancho;

        public double Largo
        {
            get { return largo; }
            set { largo = value; }
        }


        public double Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }
        public Rectangulo(double l,double a)
        {
            Largo = l;
            Ancho = a;
        }
        public override double _CalcularArea()
        {
            area = Largo * Ancho;
            return area;
        }
        public override void DibujarFigura()
        {
            Console.WriteLine("------------");
            Console.WriteLine("|          |");
            Console.WriteLine("|          |");
            Console.WriteLine("|          |");
            Console.WriteLine("------------");
        }
    }
    class Circunferencia : Figura
    {
        protected double radio;

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }
        public Circunferencia(double radio)
        {
            Radio = radio;
        }
        public override double _CalcularArea()
        {

            return area=Math.PI*(radio*radio);
        }
        public override void DibujarFigura()
        {
            Console.WriteLine("--/--------");
            Console.WriteLine("-/----------");
            Console.WriteLine("|-----------");
            Console.WriteLine("'\'----------");
            Console.WriteLine("-'\'---------");
        }


    }
    class Triangulo : Figura
    {
        protected double altura;
        protected double ancho;

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }


        public double Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }
        public Triangulo(double al, double a)
        {
            Altura = al;
            Ancho = a;
        }
        //public static implicit operator Triangulo(double[] datos)
        //{
        //    return new Triangulo(datos[1],datos[2]);
        //}
        public override double _CalcularArea()
        {
            return (area=Altura*Ancho)/2;
        }
        public override void DibujarFigura()
        {
            Console.WriteLine("        *        ");
            Console.WriteLine("       ***       ");
            Console.WriteLine("      *****      ");
            Console.WriteLine("     *******     ");
        }
    }
}
