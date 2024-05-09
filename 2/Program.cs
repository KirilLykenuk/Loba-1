using System;

namespace CylinderCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 3;
            double h = 10;

            double[] result = CalculateCylinder(r, h);
            double S = result[0];
            double V = result[1];

            Console.WriteLine("Площа бічної поверхні циліндра: " + Math.Round(S, 2));
            Console.WriteLine("Об'єм циліндра: " + Math.Round(V, 2));
        }

        static double[] CalculateCylinder(double r, double h)
        {
            double[] result = new double[2];
            double pi = Math.PI;

            double lateralSurfaceArea = 2 * pi * r * h;
            double volume = pi * Math.Pow(r, 2) * h;

            result[0] = lateralSurfaceArea;
            result[1] = volume;

            return result;
        }
    }
}
