using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teclado_Pc_POO_Tarea7
{
    class Program
    {
        static void Main(string[] args)
        {
            Teclado Teclado1 = new Teclado(3,TipoTeclado.DeMembrana);
            Teclado1.ingresarBloques(0,TipoBloque.BloqueAlfanumérico,"Letras-Numeros",70);
            Teclado1.bloques[0].AsignarTeclas(0,"[","´");

        }
    }
}
