using Microsoft.VisualBasic;

namespace TPiB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите через пробел расстояние, угол дельта, угол альфа:");
            string[] data = Console.ReadLine().Split();
            double rad = double.Parse(data[0]);
            double delta = double.Parse(data[1]);
            double alpha = double.Parse(data[2]);
            Solution(rad, delta, alpha);
        }

        static void Solution(double rad, double delta, double alpha)
        {
            double x, y, z;
            x = rad * Math.Cos(ToRad(delta)) * Math.Cos(ToRad(alpha));
            y = rad * Math.Cos(ToRad(delta)) * Math.Sin(ToRad(alpha));
            z = rad * Math.Sin(ToRad(delta));
            Console.WriteLine($"X = {x} \nY = {y}\n Z = {z}");
        }

        static double ToRad(double angle) => (Math.PI * angle / 180.0);
    }
}