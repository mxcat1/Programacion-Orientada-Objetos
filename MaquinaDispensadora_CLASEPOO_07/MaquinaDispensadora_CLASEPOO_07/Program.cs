using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDispensadora_CLASEPOO_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispensadora Dispen = new Dispensadora(10);
            Dispen._BandejaDispensador[0].CargarSeccion(0,new Producto { TipoProductoD=TipoProducto.galletas},10);
        }
    }
}
