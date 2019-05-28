using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoP1_POO28519
{
    class Figura
    {
        public double area;
        public virtual double CalcularArea()
        {
            return area;
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
        public override double CalcularArea()
        {
            area = Largo * Ancho;
            return area;
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
        public override double CalcularArea()
        {

            return area=Math.PI*(radio*radio);
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
        public override double CalcularArea()
        {
            return (area=Altura*Ancho)/2;
        }
    }
}
