using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Point
{
    public double x = 0;
    public double y = 0;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public Point()
    {
        Console.WriteLine("Write x=");
        this.x = int.Parse(Console.ReadLine());
        Console.WriteLine("Write x=");
        this.y = int.Parse(Console.ReadLine());
    }

}

namespace ConsoleAppip
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:Console.WriteLine(task1(Double.Parse(Console.ReadLine()))); break;
                case 2:Console.WriteLine(task2(Double.Parse(Console.ReadLine()))); break;
                case 3:Console.WriteLine(task3(Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()))); break;
                case 4:Console.WriteLine(task4(Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()))); break;
                case 5:Console.WriteLine(task5(new Point(), new Point(), new Point())); break;
                case 6:Console.WriteLine(task6(Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()))); break;
                case 7:Console.WriteLine(task7(Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()))); break;
                case 8:Console.WriteLine(task8(Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()))); break;
                case 9:Console.WriteLine(task9(Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()))); break;
            }            
        }

        static double task1(double s)
        {   

            return Math.Sqrt(s) * 4;
        }

        static double task2(double p)
        {
            return (p/3)*(Math.Sqrt(3) * (p / 3));
        }

        static double task3(double a, double b)
        {
            return (Math.Pow(a, 3) + Math.Pow(b, 3)) / 2;
        }

        static double task4(double a, double b)
        {
            return Math.Sqrt(Math.Abs(a * b));
        }

        static double task5(Point a1, Point a2, Point a3)
        {
            return  Math.Abs((a2.x - a1.x) * (a3.y - a1.y) - (a3.x - a1.x)*(a2.y - a1.y)) / 2;
        }

        static double task6(double r1, double r2)
        {
            return Math.PI * Math.Pow(r2, 2) - Math.PI * Math.Pow(r1, 2); 
        }

        static double task7(double r, double a)
        {
            return Math.PI * Math.Pow(r, 2) - Math.Sqrt(3) * a * a;
        }

        static double task8(double b, double n, double q)
        {
            return b * (Math.Pow(q, n) - 1) / (q - 1);
        }

        static Point task9(double b, double f, double c, double e, double a, double d)
        {
            double x = (b * f - c * e) / (a * e - b * d);
            double y = (a * x + c) / (b * -1);

            return new Point(x, y);
        }

        // Задачи без оператора IF

        //static void taskX(int n)
        //{
        //    switch (n)
        //    {
        //        case 1:
        //            // 10
        //            int x = 12 > 0 ? (12) : (0);
        //            break;
        //        case 2:
        //            // 11
        //            int y = 12 % 2 == 1 ? (1) : (0);
        //            break;
        //        case 3:
        //            // 12
        //            int z = 45 % 10 > 45 / 10 ? (45 % 10) : (45 / 10);
        //            break;
        //        case 4:
        //            // 13
        //            int A = 10;
        //            int q = (45 % 10 + 45 / 10) % A == 0 ? (1) : (0);
        //            break;
        //        case 5:
        //            // 14
        //            int a = 1, b = 2, c = 3, result = 0;
        //            result = (a >= b) || (a >= c) ? (a) : (result);
        //            result = (b >= a) || (b >= c) ? (b) : (result);
        //            result = (c >= b) || (c >= a) ? (c) : (result);

        //            Console.WriteLine(result);
        //            break;
        //        case 6:
        //            // 15
        //            double a = Double.Parse(Console.ReadLine()), b = Double.Parse(Console.ReadLine()), c = Double.Parse(Console.ReadLine());
        //            double D;
        //            D = Math.Pow(b, 2) - 4 * a * c;
        //            int gg = D == 0 ? (1) : (0);
        //            gg = D > 0 ? (2) : (0);

        //            switch (gg)
        //            {
        //                case 1:
        //                    Console.WriteLine("Один корень ->", (b * b) / (2 * a) * -1);
        //                    break;

        //                case 2:
        //                    Console.WriteLine("Два корня ->", ((b * -1) - Math.Sqrt(D)) / (2 * a), ((b * -1) + Math.Sqrt(D)) / (2 * a));
        //                    break;
        //                default:
        //                    Console.WriteLine("Нет корней");
        //                    break;
        //            }
        //            break;
        //        case 7:
        //            // 16
        //            bool f = (1 + 2 + 3 + 4) % 2 == 0 ? true : false;
        //            break;
        //        case 8:
        //            // 17
        //            f = (a + b > c && a + c > b && c + b > a) ? true : false;
        //            break;
        //        case 9:
        //            //18
        //            int a2 = 0, b2 = 0, c2 = 0;
        //            //f = a + b > c && a + c > b && c + b > a && (b2 == (a2 + c2) || c2 == (a2 + b2) || a2 = (c2 + b2)) ? true : false;
        //            break;
        //        case 10:
        //            //19
        //            f = (a + b > c && a + c > b && c + b > a && (a == c || c == b || b == a)) ? true : false;
        //            break;
        //        case 11:
        //            //20
        //            f = (a == c && c == b && b == a) ? true : false;
        //            break;

          //  }

        //}



    }
}
