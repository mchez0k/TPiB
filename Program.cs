using System;

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
            double x, y, z;
            GetAGESK(rad, delta, alpha, out x, out y, out z);
            Console.WriteLine("Введите момент S:");
            double s = double.Parse(Console.ReadLine());
            GetGOSK(x, y, z, s);

        }

        static void GetAGESK(double rad, double delta, double alpha, out double X, out double Y, out double Z)
        {
            X = rad * Math.Cos(ToRad(delta)) * Math.Cos(ToRad(alpha));
            Y = rad * Math.Cos(ToRad(delta)) * Math.Sin(ToRad(alpha));
            Z = rad * Math.Sin(ToRad(delta));
            Console.WriteLine($"Координаты в АГЭСК:\nX = {X} \nY = {Y}\nZ = {Z}");
        }

        static void GetGOSK(double x, double y, double z, double s) 
        {
            double Xg, Yg, Zg;
            Console.WriteLine($"Координаты в ГОСК для момента S = 0:\nX = {x} \nY = {y}\nZ = {z}");
            Xg = x * Math.Cos(ToRad(s)) + y * Math.Sin(ToRad(s));
            Yg = -x * Math.Sin(ToRad(s)) + y * Math.Cos(ToRad(s));
            Zg = z;            
            Console.WriteLine($"Координаты в ГОСК для момента S = {s}:\nX = {Xg} \nY = {Yg}\nZ = {Zg}");
        }

        static double ToRad(double angle) => (Math.PI * angle / 180.0);
    }
}