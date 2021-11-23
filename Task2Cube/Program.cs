using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Cube
{
    internal class Program
    {
        static void Main(string[] args)
        /*Создать метод для вычисления объема и площади поверхности куба по длине его ребра.*/
        {
            Console.WriteLine("Введите длину стороны куба");
            float a=Convert.ToSingle(Console.ReadLine());
            CalcCubeSV(a, out float Area, out float Volume);
            Console.WriteLine("Площадь поверхности куба = {0}",Area);
            Console.WriteLine("Объем куба = {0}", Volume);

            Console.ReadKey();
        }
        static void CalcCubeSV (float a, out float S, out float V)
        {
            V = a * a * a;
            S = 6 * a * a;

        }
    }
}
