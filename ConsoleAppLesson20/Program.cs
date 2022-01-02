using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson20
{
    internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            double _r;
            Console.Write("введите радиус = ");
            _r = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = LenthCircle;
            myDelegate += SquareCircle;
            myDelegate += VolumeCircle;

            if (myDelegate != null) myDelegate(_r);

            Console.ReadKey();
        }
        public static double LenthCircle(double r)
        {
            double lc = 2 * Math.PI * r;
            Console.WriteLine("Длина окружности = {0}", lc);
            return lc;
        }
        public static double SquareCircle(double r)
        {
            double sc = Math.PI * r * r;
            Console.WriteLine("Площадь окружности = {0}", sc);
            return sc;
        }
        public static double VolumeCircle(double r)
        {
            double vc = Math.PI * 4 / 3 * r * r * r;
            Console.WriteLine("Объем шара = {0}", vc);
            return vc;
        }




    }
}
