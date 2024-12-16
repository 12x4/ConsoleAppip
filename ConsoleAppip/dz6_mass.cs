using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz6
{
    public class dz6_mass
    {
        public static void print(string str)
        {

            Console.WriteLine(str);

        }

        public static string input(string str=null)
        {
            if (str != null)
            {
                Console.WriteLine(str);
            }

            return Console.ReadLine();
        }

        public static int[] get_mass_randElem(int n=10, int a = 0, int b = 100) { 
            int[] ret = new int[n];
            var rand = new Random();

            for (int i = 0; i < n; i++)
            {
                ret[i] = rand.Next(a, b);
            }

            return ret;
        }

        public static void print_massInt(int[] mass) {

            foreach (int i in mass) { 
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }

    public class modul_1: dz6_mass
    {
        public static void task_1()
        {
            int n = Int32.Parse(input("введите размер массива:"));
            int[] mass = new int[n];
            
            for (int i = 0; i < n; i++) mass[i] = Int32.Parse(input());

            for (int i = 0; i < n; i++)
            {
                if (mass[i] < 0 && mass[i] % 3 != 0)
                {
                    mass[i] = mass[i] * -1;
                }
            }

            for (int i = 0;i < n; i++) {Console.Write(mass[i] + " "); }
        }

        public static void task_2()
        {
            int n = Int32.Parse(input("введите размер массива:"));
            int[] mass = new int[n];
            for (int i = 0; i < n; i++) mass[i] = Int32.Parse(input());

            int summ = 0, N = 0;

            for (int i = 0; i < n; i++)
            {
                if (mass[i] < 0)
                {
                    summ += mass[i];
                    N++;
                }
            }

            Console.Write(summ / N);
        }

        public static void task_3()
        {
            int n = Int32.Parse(input("введите размер массива:"));
            print("Введите элементы массива:");
            int[] mass = new int[n];
            for (int i = 0; i < n; i++) mass[i] = Int32.Parse(input());

            print("Введите интервал А и В");

            int a = Int32.Parse(input("a:"));
            int b = Int32.Parse(input("b:"));

            int N = 0;

            for (int i = 0; i < n; i++)
            {
                if (i < a || i > b)
                {
                    N++;
                }
            }
            Console.Write(N);
        }

        public static void task_4()
        {
            int n = Int32.Parse(input("введите размер массива:"));
            int[] mass = new int[n];
            print("Введите элементы массива:");

            for (int i = 0; i < n; i++) mass[i] = Int32.Parse(input());

            int N = 0;

            for (int i = 0; i < n; i++)
            {
                if (mass[i] % 7 != 0)
                {
                    N++;
                }
            }

            Console.Write(N);
        }

        public static void task_5()
        {
            int n = Int32.Parse(input("введите размер массива:"));
            int[] mass = new int[n];
            print("Введите элементы массива:");

            for (int i = 0; i < n; i++) mass[i] = Int32.Parse(input());

            for (int i = 0; i < n; i++)
            {
                if (mass[i] > 0 && i % 2 != 0)
                {
                    Console.Write(mass[i] + " ");
                }
            }

        }
    }

    public class modul_2: dz6_mass
    {
        public static void task_1()
        {
            int[] mass = get_mass_randElem();
            print_massInt(mass);

            int min = int.MaxValue;

            for (int i = 0; i < mass.Length; i++) { if (mass[i] < min) { min = mass[i]; } }

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] == min) Console.Write(i + " ");

            }
        }



    }
}
