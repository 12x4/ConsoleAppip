using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using dz6;
using dz5;
using System.Diagnostics;



class Point
{
    public double x, y;

    public Point()
    {
        Console.WriteLine("Write x :");
        this.x = Double.Parse(Console.ReadLine());
        Console.WriteLine("Write y :");
        this.y = Double.Parse(Console.ReadLine());

    }

    Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
}


namespace lowTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dz6.dz6_mass.print("Введите номер");
            int n = Int32.Parse(Console.ReadLine());
            switch (n)
            {
                case 1: dz8.modul_1.task_1(); break;
                case 2: dz8.modul_1.task_2(); break;
                case 3: dz8.modul_1.task_3(); break;
                case 4: dz8.modul_1.task_4(); break;
                case 5: dz8.modul_1.task_5(); break;
                case 6: dz8.modul_1.task_6(); break;
                case 7: dz8.modul_1.task_7(); break;
                case 8: dz8.modul_1.task_8(); break;
                case 9: dz8.modul_1.task_9(); break;
                case 10: dz8.modul_1.task_10(); break;
                default: dz6.dz6_mass.print("Научись вводить числа, парень"); break;
            }            
        }
    }

    
}
