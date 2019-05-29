using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoConcatenacion_POOT1
{
    //Primera Forma
    class MiStringI
    {
        char[] CadenaUnida;
        public MiStringI(params string[] cadenas)
        {
            int cantidadcadenas = 0;
            foreach (string cadena in cadenas)
            {
                cantidadcadenas += cadena.Length;
            }
            CadenaUnida = new char[cantidadcadenas];
            int conta = 0;
            foreach (string cadena in cadenas)
            {
                
                for (int i = 0; i < cadena.Length; i++)
                {
                    CadenaUnida[conta] = cadena[i];
                    conta ++;
                }

            }
        }
        public override string ToString()
        {
            
            return new string(CadenaUnida);
        }
       
    }
    //Segunda Forma
    class MiStringII
    {
        // Atributos/Propiedades 
        // Para no perder la costumbre 
        private string _cadena;

        public string Cadena
        {
            get { return _cadena; }
            set { _cadena = value; }
        }

        public MiStringII(string cad)
        {
            this.Cadena = cad;
        }
        // metodo implicito para asignar la cadena de caracteres con el =
        public static implicit operator MiStringII(string s)
        {
            return new MiStringII(s);
        }
        public static string sumarstring(params MiStringII[] cadenas)
        {
            int canti = 0;
            foreach (MiStringII cad1 in cadenas)
            {
                canti += cad1.Cadena.Length;
            }
            char[] cadenafinal=new char[canti];
            //contador
            int conta = 0;
            foreach (MiStringII cad1 in cadenas)
            {

                for (int i=0;i<cad1.Cadena.Length;i++){
                    cadenafinal[conta] = cad1.Cadena[i];
                    conta++;
                }
                
            }
            return new string (cadenafinal);
        }
        public override string ToString()
        {
            return this.Cadena;
        }
    }

    //Tercera Forma
    class MiStringIII
    {
        // Atributos/Propiedades 
        // Para no perder la costumbre 
        private string _micadena;

        public string Micadena
        {
            get { return _micadena; }
            set { _micadena = value; }
        }
        //XD
        public MiStringIII(object cad)
        {
            _micadena = cad.ToString();
        }
        //Sobrecarga del metodo Implicit para la asignacion
        public static implicit operator MiStringIII(string s)
        {
            return new MiStringIII(s);
        }
        public static implicit operator MiStringIII(decimal s)
        {
            return new MiStringIII(s);
        }
        public static implicit operator MiStringIII(float s)
        {
            return new MiStringIII(s);
        }
        public static implicit operator MiStringIII(double s)
        {
            return new MiStringIII(s);
        }
        public static implicit operator MiStringIII(int s)
        {
            return new MiStringIII(s);
        }
        public static implicit operator MiStringIII(bool s)
        {
            return new MiStringIII(s);
        }
        public static MiStringIII operator +(MiStringIII a,MiStringIII b)
        {
            int tamaniocadena = a.Micadena.Length + b.Micadena.Length;
            char[] cadenafinaldinal = new char[tamaniocadena];
            //contador
            int d = 0;

            foreach (char caracter in a.Micadena)
            {
                cadenafinaldinal[d] = caracter;
                d++;
            }
            foreach (char caracter in b.Micadena)
            {
                cadenafinaldinal[d] = caracter;
                d++;
            }
            return new MiStringIII(new string(cadenafinaldinal));

        }
        public override string ToString()
        {
            return Micadena;
        }

    }
}
