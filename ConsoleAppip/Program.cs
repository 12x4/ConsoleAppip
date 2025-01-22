using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using dz6;
using dz5;
using dz9;
using new_word_CLass;
using System.Text.RegularExpressions;

using System.Diagnostics;
using System.Linq.Expressions;



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
            //RegexTwo reC = new RegexTwo();
            //Regex reg = new Regex(@"\D+", RegexOptions.Multiline);

            //string target = "g09ugdg0df0909d  0fg 09dfgd99dKJNJ";

            //reC.regexF = reg;
            //reC.text = target;

            //reC.delRegForm();
            ////reC.writeAllContainsForms();

            //Console.WriteLine(reC.text);

            /////////////////////////////////////////////////////////

            //DataTimeTwo data = new DataTimeTwo();

            //data.dataNext();

            //Console.WriteLine(data.Data);

            testStringTwo();


        }

        public static void testStringTwo()
        {
            stringTwo _string = new stringTwo(10);

            _string.Word = "Dyrak";

            Console.WriteLine(_string[4]);


        }
    }
}
