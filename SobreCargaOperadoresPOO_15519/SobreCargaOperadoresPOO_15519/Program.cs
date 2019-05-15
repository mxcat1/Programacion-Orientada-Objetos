using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargaOperadoresPOO_15519
{
    class area
    {
        float _largo;
        float _ancho;


        public float largo
        {
            get { return _largo; }
            set { _largo = value; }
        }
        public float ancho
        {
            get { return _ancho; }
            set { _ancho = value; }
        }


        public area(float l,float a)
        {
            largo = l;
            ancho = a;
        }
        public static area operator +(area a ,area b)
        {
            area c = new area(b._largo+a._largo,a._ancho+b._ancho);
            return c;
        }
        public static area operator ++(area a)
        {
            a.ancho++;
            a.largo++;
            return a;
        }
        public override string ToString()
        {
            return "Ancho : "+this.ancho + " Largo: " + this.largo; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            area a = new area(5,6);
            area b = new area(7, 4);
            area d = new area(8,5);
            area c = a + b + d;
            //Console.Write(c.largo+" "+c.ancho+" "+a.largo);
            Console.WriteLine(c.ToString());
            a++;
            Console.WriteLine(a.ToString());
            Console.ReadLine();
        }
    }
}
