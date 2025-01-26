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
            testDateTimeTwo();
        }

        public static void testRegexTwo()
        {
            RegexTwo reC = new RegexTwo();
            Regex reg = new Regex(@"\D+", RegexOptions.Multiline);

            string target = "g09ddd123ugdg0df0909d  0fg 09dfgd99dKJNJ";

            reC[0] = reg;
            reC[1] = target;

            //reC.delRegForm();
            reC.writeAllContainsForms();

            Console.WriteLine(reC.text);
        }

        public static void testStringTwo()
        {
            stringTwo _string = new stringTwo(10);
            _string = "Dyrak";

            stringTwo _string_new = new stringTwo(10);
            _string_new.Word = "Dyrak";

            Console.WriteLine(_string & _string_new);

            Console.WriteLine(_string);

        }

        public static void testDateTimeTwo()
        {
            DateTimeTwo data = new DateTimeTwo();

            data.dataNext();

            string data_str = data;

            Console.WriteLine(data[-100]);

            Console.WriteLine((DateTimeTwo)data_str);
            Console.WriteLine(data.Data);
        }
    }
}
