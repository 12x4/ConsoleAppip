using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using dz6;
using dz5;



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

            dz6.modul_4.task_5();

        }
    }

    
}
