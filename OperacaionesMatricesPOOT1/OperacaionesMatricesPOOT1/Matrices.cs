using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacaionesMatricesPOOT1
{
    //por ahora el codigo es solo para matrices cuadradas
    class Matriz
    {
        int columMatriz;
        int filaMatriz;
        double[,] valores;

        public Matriz(int dimematriza = 3)
        {
            this.columMatriz = dimematriza;
            this.filaMatriz = dimematriza;
            valores = new double[this.filaMatriz, this.columMatriz];
        }

        public double this[int x, int y]
        {
            get { return valores[x, y]; }
            set { valores[x, y] = value; }
        }
        // llenar matriz con varios paramatros
        // solo para matrices de 3x3
        public void llenarmatriz(params double[] valores)
        {
            int aumento =0;
            for (int x=0;x<this.columMatriz;x++)
            {
                for(int y = 0; y < this.columMatriz; y++)
                {
                    this[x, y] = valores[y+aumento];
                }
                aumento += 3;
            }
        }
        // llenar aleatoriamente la matriz
        public void llenarmatrizale(int min, int max)
        {
            Random valorale = new Random();
            for (int x = 0; x < this.columMatriz; x++)
            {
                for (int y = 0; y < this.columMatriz; y++)
                {
                    this[x, y] = valorale.Next(min, max);
                }

            }
        }
        // Mostrar matriz
        public void verMatriz()
        {

            for (int x = 0; x < this.columMatriz; x++)
            {
                for (int y = 0; y < this.columMatriz; y++)
                {
                    Console.Write(" | "+this[x, y] + "  ");
                }
                Console.Write("| \n");
            }
        }



        //Sobrecarga de Suma de matrices
        public static Matriz operator +(Matriz a, Matriz b)
        {
            Matriz c = new Matriz(a.columMatriz);

            for (int x = 0; x < a.columMatriz; x++)
            {
                for (int y = 0; y < a.columMatriz; y++)
                {
                    c[x, y] = a[x, y] + b[x, y];
                }
            }
            return c;
        }

        //sobrecarga de Resta de matrices
        public static Matriz operator -(Matriz a, Matriz b)
        {
            Matriz c = new Matriz(a.columMatriz);

            for (int x = 0; x < a.columMatriz; x++)
            {
                for (int y = 0; y < a.columMatriz; y++)
                {
                    c[x, y] = a[x, y] - b[x, y];
                }
            }
            return c;
        }
        // Multiplicacion de matrices
        public static Matriz operator *(Matriz a, Matriz b){
            Matriz c = new Matriz(a.columMatriz);
            double almacenado;
            for (int x = 0; x < a.columMatriz; x++)
            {
                for (int y = 0; y < a.columMatriz; y++)
                {
                    almacenado = 0;
                    for (int y1 = 0; y1 < a.columMatriz; y1++)
                    {

                        almacenado += a[x, y1] * b[y1, y];
                    }
                    c[x, y] = almacenado;
                }


                
            }
            return c;
        }

    }
}
