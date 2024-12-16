using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5
{
    public class modul_2
    {
        public static void task_1()
        {
            Console.WriteLine("true - n ный член, false - сумма n первых членов");
            bool yuo = bool.Parse(Console.ReadLine());

            Console.WriteLine("Введите n:");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите разность арефмитической прогресии:");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите первый член:");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine(task_1_core(n, b, a, yuo));
        }
        static int task_1_core(int n, int b, int a, bool yuo)
        {
            if (n == 0) return a;
            if (yuo) return b + task_1_core(n - 1, b, a, yuo);
            else return (b * n) + task_1_core(n - 1, b, a, yuo);
        }

        public static void task_2()
        {
            Console.WriteLine("true - n ный член, false - сумма n первых членов");
            bool yuo = bool.Parse(Console.ReadLine());

            Console.WriteLine("Введите n:");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите знаминатель:");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите первый член:");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine(task_2_core(n, b, a, yuo));
        }
        static double task_2_core(int n, double b, double a, bool yuo)
        {
            if (n == 0) return a;
            if (yuo) return b * task_2_core(n - 1, b, a, yuo);
            else return Math.Pow(b, n) * a + task_2_core(n - 1, b, a, yuo);
        }

        public static void task_3()
        {
            Console.WriteLine("Write N:");
            int N = Int32.Parse(Console.ReadLine());
            task_3_core(N);
        }
        static int task_3_core(int N)
        {
            if (N == 0) return 0;
            task_3_core(N - 1);
            Console.Write(N + " ");
            return 0;
        }

        public static void task_4()
        {
            Console.WriteLine("Write N:");
            int N = Int32.Parse(Console.ReadLine());
            task_4_core(N);
        }
        static int task_4_core(int N)
        {
            if (N == 0) return 0;
            Console.Write(N + " ");
            task_4_core(N - 1);
            return 0;
        }

        public static void task_5()
        {
            Console.WriteLine("Write N:");
            int N = Int32.Parse(Console.ReadLine());
            task_5_core(N);
        }
        static int task_5_core(int N)
        {
            if (N == 0)
            {
                Console.WriteLine("И больше лунатиков не стало на луне");
                return 0;
            }

            Console.WriteLine($"{N} лунатиков жили на луне");
            Console.WriteLine($"{N} лунатиков ворочались во сне");
            Console.WriteLine($"Один из лунатиков упал с луны во сне");

            if (N - 1 != 0) Console.WriteLine($"{N - 1} лунатиков осталось на луне");
            task_5_core(N - 1);
            return 0;
        }

        public static void task_6()
        {
            Console.WriteLine("Write N:");
            int N = Int32.Parse(Console.ReadLine());
            task_6_core(N);
        }
        static int task_6_core(int N)
        {
            if (N == 0) return 0;

            task_6_core(N - 1);

            for (int i = N; i > 0; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            return 0;
        }

        public static void task_7()
        {
            Console.WriteLine("Write N:");
            string number = Console.ReadLine();
            task_7_core(number);
        }
        static int task_7_core(string number)
        {
            if (number.Length == 0) return 0;

            task_7_core(number.Remove(number.Length - 1, 1));

            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();

            return 0;
        }

        public static void task_8()
        {
            Console.WriteLine("Write N:");
            string number = Console.ReadLine();
            Console.WriteLine(task_8_core(number));
        }
        static double task_8_core(string number)
        {
            if (number.Length == 0) return 0;
            return Math.Pow(2, number.Length - 1) * (Int32.Parse(number) / (int)Math.Pow(10, number.Length - 1)) + task_8_core(number.Remove(0, 1));
        }

        public static void task_9()
        {
            Console.WriteLine("Write N:");
            int n = Int32.Parse(Console.ReadLine());
            task_9_core(n, n, true);
            for (int i = n + 2; i > 0; i--) Console.Write("*");
            Console.WriteLine();

            task_9_core(n, n, false);
        }
        static double task_9_core(int n, int N, bool m)
        {
            if (n <= 0) return 0;

            if (m == true)
            {
                for (int i = (N - n + 2) / 2; i > 0; i--) Console.Write("*");
                for (int i = n; i > 0; i--) Console.Write(" ");
                for (int i = (N - n + 2) / 2; i > 0; i--) Console.Write("*");
                Console.WriteLine();

                task_9_core(n - 2, N, true);
            }
            else
            {
                for (int i = (n / 2); i > 0; i--) Console.Write("*");
                for (int i = N - n + 2; i > 0; i--) Console.Write(" ");
                for (int i = (n / 2); i > 0; i--) Console.Write("*");
                Console.WriteLine();

                task_9_core(n - 2, N, false);
            }

            return 0;

        }

        public static void task_10()
        {
            string alf = "ABCDEFGHIJKLMNOPQRSTUVWXY";

            task_10_core(80, 0, true, alf);

            for (int i = 25; i > 0; i--) Console.Write(" ");
            for (int i = 30; i > 0; i--) Console.Write("Z");
            Console.WriteLine();

            task_10_core(80, 24, false, alf);
        }
        static int task_10_core(int n, int N, bool m, string alf)
        {
            if (N >= 25 || N <= -1) return 0;

            if (m == true)
            {
                for (int i = N; i > 0; i--) Console.Write(" ");
                for (int i = n - (N * 2); i > 0; i--) Console.Write(alf[N]);
                Console.WriteLine();

                task_10_core(n, N + 1, true, alf);
            }
            else
            {

                for (int i = N; i > 0; i--) Console.Write(" ");
                for (int i = n - (N * 2); i > 0; i--) Console.Write(alf[N]);
                Console.WriteLine();

                task_10_core(n, N - 1, false, alf);
            }

            return 0;

        }
    }
}
