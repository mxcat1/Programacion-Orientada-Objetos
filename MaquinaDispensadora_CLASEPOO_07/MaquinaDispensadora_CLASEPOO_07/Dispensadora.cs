using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDispensadora_CLASEPOO_07
{
    public class RespuestaMetodo
    {
        public int Codigo { get; set; }
        public string Mensaje { get; set; }
        public RespuestaMetodo(int codigo=0,string mensaje="")
        {
            Codigo = codigo;
            Mensaje=mensaje;
        }
    }
    public class Producto
    {
        public TipoProducto TipoProductoD;
    }
    public enum TipoProducto
    {
        ninguno=0,galletas=1,chocolate=2
    }
    public class Dispensadora
    {
        public Bandeja[] _BandejaDispensador { get; set; }
        
        public Dispensadora(int cantibadejas=0)
        {
            if (cantibadejas == 0) {
                _BandejaDispensador = new Bandeja[] { };
            }
            else {
                _BandejaDispensador = new Bandeja[cantibadejas];
                int l = _BandejaDispensador.Length;
                for(int i = 0; i < l; i++)
                {
                    _BandejaDispensador[i] = new Bandeja();
                }
            }
            
        }
        ~Dispensadora()
        {
            _BandejaDispensador = null;
        }

    }
    public class Bandeja
    {
        public Producto[][] SeccionProducto { get; set; }
        public Bandeja(int nsecciones=1)
        {
            SeccionProducto = new Producto[nsecciones][];
            for (int i = 0; i < nsecciones; i++){
                SeccionProducto[i] = new Producto[] { };
            }
        }
        ~Bandeja()
        {

        }
        public RespuestaMetodo CargarSeccion(int seccion,Producto p,int cantiproducto)
        {
            RespuestaMetodo _rpta = new RespuestaMetodo(); ;
            if ((seccion<0)||(seccion > SeccionProducto.Length))
            {
                _rpta = new RespuestaMetodo(1,"Indice de la seccion fuera del limite");
                return _rpta;
            }
            if (cantiproducto<0)
            {
                _rpta = new RespuestaMetodo(2,"Cantidad de productos debe ser mayor a cero");
                return _rpta;
            }
            SeccionProducto[seccion] = new Producto[cantiproducto];
            
            return _rpta;
        }
    }
}
