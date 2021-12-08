using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_Lesson20
{
    class Program
    {
        delegate double MyDelegate(double radius);
        static void Main(string[] args)
        {
            Console.Write("Для вычисления длинны окружности, площади коуга и объема шара введите радиус= ");
            double radius = Convert.ToDouble(Console.ReadLine());

            MyDelegate myDelegate1 = new MyDelegate(Method1Circlelength);
            double l = myDelegate1(radius);
            Console.WriteLine(" Длина окружности L ={0:f3}", l);
            Console.WriteLine(" Press any key to continue...");
            Console.ReadKey();

            MyDelegate myDelegate2 = new MyDelegate(Method2Circlesquare);
            double s = myDelegate1(radius);
            Console.WriteLine(" Площадь круга S ={0:f3}", s);
            Console.WriteLine(" Press any key to continue...");
            Console.ReadKey();

            MyDelegate myDelegate3 = new MyDelegate(Method3Ballvulue);
            double v = myDelegate3(radius);
            Console.WriteLine(" Объем шара S ={0:f3}", s);
            Console.WriteLine(" Press any key to continue...");
            Console.ReadKey();
        }
        static double Method1Circlelength( double radius)
        {
            double l = 2 * Math.PI * radius;
            return l;
        }
        static double Method2Circlesquare(double radius)
        {
            double s = Math.PI * Math.Pow(radius,2);
            return s;
        }
        static double Method3Ballvulue(double radius)
        {
            double v = 4/3 * Math.PI * Math.Pow(radius, 3);
            return v;
        }
    }
}
