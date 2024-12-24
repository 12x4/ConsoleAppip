using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using dz6;

namespace dz7
{
    public class dz7_string : dz6_mass
    {

    }

    public class modul_1 : dz7_string
    {
        public static void task_1()
        {
            print("Write string:");
            String strWrt = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < strWrt.Length / 2; i++)
            {
                sb.Append(strWrt[i * 2 + 1]);
                sb.Append(strWrt[i * 2]);
            }

            if (strWrt.Length % 2 == 1) sb.Append(strWrt[strWrt.Length - 1]);

            Console.WriteLine(sb.ToString());
        }

        public static void task_2()
        {
            print("Write string:");
            String strWrt = Console.ReadLine().ToLower();

            string[] strArrayX = strWrt.Split(new char[] { 'x' });
            string[] strArrayY = strWrt.Split(new char[] { 'y' });

            Console.WriteLine("X: " + (strArrayX.Length - 1));
            Console.WriteLine("Y: " + (strArrayY.Length - 1));
        }

        public static void task_3()
        {
            print("Write string:");
            String strWrt = Console.ReadLine().ToLower();

            Console.WriteLine("First: " + strWrt.IndexOf("x"));
            Console.WriteLine("Last: " + strWrt.LastIndexOf("x"));
        }

        public static void task_4()
        {
            print("Write string:");
            String strWrt = Console.ReadLine().ToLower();

            print("Write substr1:");
            String substr1 = Console.ReadLine().ToLower();
            print("Write substr1:");
            String substr2 = Console.ReadLine().ToLower();

            String result = strWrt.Replace(substr1, substr2);

            Console.WriteLine(result);
        }

        public static void task_5()
        {
            print("Write string:");
            String strWrt = Console.ReadLine() + " ";
            StringBuilder sb = new StringBuilder();

            bool test = false;

            for (int i = 0; i < strWrt.Length - 1; i++)
            {
                if (strWrt[i] == '.' && strWrt[i + 1] == '.' && !test)
                {
                    test = true;
                    sb.Append("…");
                }
                if (strWrt[i] != '.') { test = false; }

                if (!test) { sb.Append(strWrt[i]); }

            }
            Console.WriteLine(sb.ToString());

        }

        public static void task_6()
        {
            print("Write string:");
            String strWrt = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            bool test = false;

            for (int i = 0; i < strWrt.Length; i++)
            {
                if (strWrt[i] == '(') test = true;

                if (!test) sb.Append(strWrt[i]);

                if (strWrt[i] == ')') test = false;
            }

            Console.WriteLine(sb.ToString());
        }

        public static void task_7()
        {
            print("Write string:");
            String strWrt = Console.ReadLine();
            List<Char> array = new List<Char>();

            for (int i = 0; i < strWrt.Length; i++)
            {
                if (!array.Contains(strWrt[i])) { array.Add(strWrt[i]); }
            }
            Console.WriteLine(array.Count());

        }
    }

    public class modul_2 : dz7_string
    { 
        public static void task_1()
        {
            print("Write string:");
            String strWrt = Console.ReadLine();

            strWrt.Replace(",", "");
            strWrt.Replace(".", "");
            strWrt.Replace("?", "");
            strWrt.Replace("!", "");
            strWrt.Replace("-", "");

            String[] strArray = strWrt.Split(new char[] { ' ' });

            String num = "1234567890";

            foreach (String s in strArray)
            {
                foreach (Char c in num)
                {
                    if (s.Contains(c))
                    {
                        Console.WriteLine(s);
                        break;
                     }

                }
            }
        }

        public static void task_2()
        {
            print("Write string:");
            String strWrt = Console.ReadLine();

            String num = ",.?!-";
            String absLow = "абвеёикосуыэюя";
            String absUp = absLow.ToUpper();

            for (int i = 0; i < absLow.Length; i++)
            {
                strWrt = strWrt.Replace(" а ", " ");
                strWrt = strWrt.Replace(" " + absUp[i] + " ", " ");

                for (int j = 0; j < num.Length; j++)
                {
                    strWrt = strWrt.Replace(" " + absLow[i] + num[j], " " + num[j]);
                    strWrt = strWrt.Replace(" " + absUp[i] + num[j], " " + num[j]);

                }
            }

            Console.WriteLine(strWrt);


        } // не работает

        public static void task_3()
        {
            print("Write string:");
            String[] strWrt = Console.ReadLine().Split();

            int n = 0;

            foreach (String str in strWrt)
            {
                if (str == str.ToLower())
                {
                    n ++;
                }
            }

            Console.WriteLine(n);
        }

        public static void task_4()
        {
            print("Write string:");
            String[] strWrt = Console.ReadLine().Split();

            int n = 0, min = int.MaxValue;

            foreach (String str in strWrt)
            {
                if (str.Length < min && str.Length != 0)
                {
                    min = str.Length;
                }
            }

            foreach (String str in strWrt)
            {
                if (str.Length == min)
                {
                    Console.WriteLine(str);
                }
            }
        }

        public static void task_5()
        {
            print("Write string:");
            String strWrt = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            String num = ",.?!-";

            bool flag = false;
            bool flag2 = false;

            for (int i = 0; i < strWrt.Length; i++)
            {   
                if (strWrt[i] == ' ')
                {
                    flag = true;
                }

                if (num.Contains(strWrt[i]) ) 
                {
                    sb.Append(strWrt[i]);
                    sb.Append(' ');

                    flag = true;
                    flag2 = true;
                }

                if (!num.Contains(strWrt[i]) && strWrt[i] != ' ')
                {
                    if (!flag2 && flag)
                    {
                        sb.Append(' ');
                        flag2 = false;
                    }
                    flag = false;
                }

                if (!flag)
                {   
                    sb.Append(strWrt[i]);
                }
            }


            Console.WriteLine(sb.ToString());


        }

        public static void task_6()
        {
            print("Write string:");
            String[] strWrt = Console.ReadLine().Split();

            print("Write n:");
            int n = Int32.Parse(Console.ReadLine());

            String control = "";

            foreach (String str in strWrt)
            {
                int count = 0;
                foreach (String str2 in strWrt)
                {
                    if (str == str2)
                    {
                        count++;
                    }
                }
                if (count >= n && !control.Contains(str)) { 
                    Console.WriteLine(str);
                    control += str + "_";
                }
            }
        }

        public static void task_7()
        {
            print("Write string:");
            String[] strWrt = Console.ReadLine().Split();

            int[] ints = new int[strWrt.Length];

            for (int i = 0; i < strWrt.Length; i++) ints[i] = strWrt[i].Length;
            Array.Sort(ints);

            foreach (int i in ints) {
                foreach (String str in strWrt)
                {
                    if (i == str.Length) {
                        Console.WriteLine(str);
                    }
                }
            }
        }
    }

}
