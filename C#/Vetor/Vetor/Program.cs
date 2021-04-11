using System;
using System.Globalization;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {

            //Sem Objeto

            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for(int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for(int i = 0; i<n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("AVG Height " +avg.ToString("F2"+CultureInfo.InvariantCulture));

            //Com objeto

            n = int.Parse(Console.ReadLine());

            Product[] vect2 = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect2[i] = new Product { Name = name, Price = price };
            }

            sum = 0.0;

            for(int i = 0; i<n; i++)
            {
                sum += vect2[i].Price; 
            }

            avg = sum / n;
            Console.WriteLine("AVG Price = "+ avg.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
