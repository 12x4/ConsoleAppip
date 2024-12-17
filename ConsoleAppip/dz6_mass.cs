using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public static int get_index_Max(int[] mass)
        {
            int n = int.MinValue, index = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > n)
                {
                    n = mass[i];
                    index = i;
                }
            }
            return index;
        }

        public static int get_index_Min(int[] mass)
        {
            int n = int.MaxValue, index = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < n)
                {
                    n = mass[i];
                    index = i;
                }
            }
            return index;
        }

        public static int[][] get_mssNNrnd(int n = 10, int a = 0, int b = 100)
        {
            int[][] mass = new int[n][];
            for (int i = 0;i < n;i++) mass[i] = new int[n];
            var rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) mass[i][j] = rand.Next(a, b);
            }

            return mass;
        }

        public static void print_msIntNN(int[][] mass)
        {

            foreach (int[] i in mass)
            {
                foreach (int j in i)
                {
                    Console.Write(j + " ");

                }
                Console.WriteLine();
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

        public static void task_2()
        {
            int[] mass = get_mass_randElem();
            print_massInt(mass);

            int minInd = get_index_Min(mass);
            int maxInd = get_index_Max(mass);

            mass[maxInd] = mass[maxInd] + mass[minInd];
            mass[minInd] = mass[maxInd] - mass[minInd];
            mass[maxInd] -= mass[minInd];

            print_massInt(mass);


        }

        public static void task_3()
        {
            int[] mass = get_mass_randElem();
            print_massInt(mass);

            int a = Int32.Parse(input("Write A:"));
            int b = Int32.Parse(input("Write B:"));

            int summ = 0;

            for (int i = a; i < b; i++) { summ += mass[i]; }

            Console.WriteLine(summ);
        }

        public static void task_4()
        {
            int[] mass = get_mass_randElem(20, -100, 100);
            print_massInt(mass);

            int min = int.MaxValue;

            foreach (int i in mass)
            {

                if (i < min && i > 0)
                {
                    min = i;
                }

            }
            Console.WriteLine(min);
        }

        public static void task_5()
        {
            int[] mass = get_mass_randElem(20);
            print_massInt(mass);
            int count = 0;

            for (int i = 0; i < mass.Length - 1; i++)
            {
                if (mass[i + 1] % mass[i] == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }

    public class modul_3: dz6_mass
    {
        public static void task_1()
        {
            int[][] mass = get_mssNNrnd(3);
            print_msIntNN(mass);

            int summ = 0;

            for (int i = 0;i < mass.Length; i++)
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    summ += mass[j][i];
                }
            }
            Console.WriteLine(summ);
        }

        public static void task_2()
        {
            int[][] mass = get_mssNNrnd();
            print_msIntNN(mass);

            int rev = 0;

            if (mass.Length % 2 == 1) return;

            for (int i = 0; i < mass.Length / 2; i++)
            {
                for (int j = 0; j < mass.Length; j++)
                {
                    rev = mass[j][i * 2];
                    mass[j][i * 2] = mass[j][i * 2 + 1];
                    mass[j][i * 2 + 1] = rev;
                }
            }

            print_msIntNN(mass);
        }

        public static void task_3()
        {
            int k = Int32.Parse(input("Write k"));
            int m = Int32.Parse(input("Write m"));

            int[][] mass = new int[m][];
            for (int i = 0; i < m; i++) { mass[i] = new int[k]; }

            int n = m * k;
            bool bib = true;
            int x = 0, y = 0;

            for (int i = 1; i <= n; i++)
            {
                mass[y][x] = i;

                if (bib) { y++; }
                else { y--; }


                if (i + 1 > n) { break; }


                if (y == m)
                {
                    bib = false;
                    x += 1;
                    i += 1;
                    mass[y - 1][x] = i;
                    y -= 2;
                }
                if (i > n) { break; }

                if (y == -1)
                {
                    bib = true;
                    x += 1;
                    i += 1;
                    mass[y + 1][x] = i;
                    y += 2;

                }
                if (i > n) { break; }

            }

            foreach (int[] i in mass)
            {
                foreach(int j in i) Console.Write(j + " ");
                Console.WriteLine();
            }

        }

        public static void task_4()
        {
            int[][] mass = get_mssNNrnd();

            print_msIntNN(mass);

            for (int i = 0; i < mass.Length; i++) 
            {
                int min = get_index_Min(mass[i]);
                int max = get_index_Max(mass[i]);
                mass[i][min] = mass[i][min] + mass[i][max];
                mass[i][max] = mass[i][min] - mass[i][max];
                mass[i][min] -= mass[i][max];

            }

            print_msIntNN(mass);
        }

        public static void task_5()
        {
            int[][] mass = get_mssNNrnd(10, -100, 100);

            print_msIntNN(mass);

            for (int i = 0; i < mass.Length; i++)
            {
                bool b = true;
                for (int j = 0; j < mass[i].Length; j++) {
                    if (mass[j][i] > 0) b = false;
                }
                if (b) { 
                    Console.WriteLine("YES");
                    return;
                }
            }
            Console.WriteLine("NO");
        }
    }

    public class modul_4 : dz6_mass
    {
        public static void task_1()
        {
            int[][] mass = get_mssNNrnd();
            int[] vect = get_mssNNrnd()[0];

            print_msIntNN(mass);
            print_massInt(vect);
            Console.WriteLine();

            for (int i = 1; i < mass.Length; i += 2) 
            {
                for (int j = 0;j < mass[i].Length; j++)
                {
                    mass[j][i] = vect[j];

                }
            }

            print_msIntNN(mass);
        }

        public static void task_2()
        {
            int[][] mass = get_mssNNrnd(10, 0, 4);
            int[] vect = get_mssNNrnd(10, 0, 4)[0];

            print_msIntNN(mass);
            print_massInt(vect);
            Console.WriteLine();

            int[] reslt = new int[mass.Length];

            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for(int k = 0; k < mass.Length; k++)
                    {
                        reslt[i] += mass[i][k] * vect[k];
                    }

                }
            }

            print_massInt(reslt);
        }

        public static void task_3()
        {
            int[][] mass = get_mssNNrnd(10, -10, 10);

            print_msIntNN(mass);
            Console.WriteLine();

            int[] reslt = new int[mass.Length];

            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length; j++)
                {
                    if (mass[i][j] < 0) reslt[i] += mass[i][j];
                }
            }

            print_massInt(reslt);
        }

        public static void task_4()
        {
            int[][] mass = get_mssNNrnd(10, -10, 10);

            print_msIntNN(mass);
            Console.WriteLine();

            int[] reslt = new int[mass.Length];

            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length - 1; j++)
                {
                    if (mass[i][j] == mass[i][j + 1])
                    {
                        reslt[i] = j;
                        break;
                    }
                }
            }

            print_massInt(reslt);
        }

        public static void task_5()
        {
            int[][] mass = get_mssNNrnd(10, -10, 10);

            print_msIntNN(mass);
            Console.WriteLine();

            int[] reslt = new int[mass.Length];
            for(int i = 0; i < mass.Length; i++) reslt[i] = 1;

            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length; j++)
                {
                    reslt[i] *= mass[i][j];
                }
            }

            print_massInt(reslt);
            Console.WriteLine("Min:" + reslt[get_index_Min(reslt)]);
        }
    }
}
