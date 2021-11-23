using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        /*Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).
         * Для решения задачи можно использовать формулу Герона */
        {
            Console.WriteLine("Введите длины сторон первого треугольника");
            float x1 = Convert.ToSingle(Console.ReadLine());
            float y1 = Convert.ToSingle(Console.ReadLine());
            float z1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите длины сторон второго треугольника");
            float x2 = Convert.ToSingle(Console.ReadLine());
            float y2 = Convert.ToSingle(Console.ReadLine());
            float z2 = Convert.ToSingle(Console.ReadLine());

            float area1 = CalcTriangleArea(x1, y1, z1);
            float area2 = CalcTriangleArea(x2, y2, z2);

            if (area1 > area2)
            {
                Console.WriteLine("Площадь первого треугольника {0:f3} больше, чем площадь второго треугольника {1:f3}", area1, area2);
            }
            else if (area2 > area1)
                Console.WriteLine("Площадь второго треугольника {1:f3} больше, чем площадь первого треугольника {0:f3}", area1, area2);
            else
                Console.WriteLine("Площади треугольников равны и составляют {0:f3}", area1);
            Console.ReadKey();
        }

        static float CalcTriangleArea (float a, float b, float c)
        {
            float p = (a + b + c) / 2;
            float s=Convert.ToSingle(Math.Sqrt(p*(p-a)*(p-b)*(p-c)));
            return s;
        }
    }
}
