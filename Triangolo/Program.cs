using System;

namespace Triangolo
{
    class Program
    {
        static void Main(string[] args)
        {
            double perimetro = 0;
            double area = 0;
            Console.WriteLine("Inserisci primo lato");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci secondo lato");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci terzo lato");
            double c = double.Parse(Console.ReadLine());
            if (a == b && a == c && b == c)
            {
                Console.WriteLine("il tiangolo è equilatero");
                perimetro = (a + b + c);
                double altezza = Math.Sqrt(3) / 2 * a;
                area = c * altezza / 2;
                Console.WriteLine($"il perimetro è {perimetro} e l'area è {area}");

            }
            else Console.WriteLine("non è un triangolo equilatero");
            Console.ReadLine();
        }
    }
}
