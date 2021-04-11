using System;
using System.Globalization;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 -3 10
            //15 8 2
            //7 9 -4
            int neg = 0, i = 0, j = 0 ;
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            double[,] mat = new double[n, n];

            for (i = 0; i < n; i++)
            {
                //Digitar todos numeros de uma linha
                string[] values = Console.ReadLine().Split(' ');

                for (j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                    if(mat[i,j] < 0)
                    {
                        neg++;
                    }
                    if(i == j)
                    {
                        vect[i] = mat[i, j];
                    }
                }
               
            }
            Console.WriteLine("Main diagonal: ");
            i = 0;
            while (i < n)
            {
                Console.Write(vect[i]+" ");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Negative numbers = "+ neg);

                Console.ReadKey();
            
        }
    }
}
