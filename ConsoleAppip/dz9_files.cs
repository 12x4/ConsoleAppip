using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Diagnostics.Tracing;

using _mass = dz6.dz6_mass;
using System.Security.Permissions;
using System.Runtime.InteropServices;

namespace dz9
{
    public class _boom
    {
        internal static FileStream getFileInt(string file_name)
        {
            try
            {
                FileStream fileInt = new FileStream(file_name, FileMode.Open, FileAccess.Read);
                return fileInt;
            }

            catch (Exception a)
            {

                Console.WriteLine(a.Message);

            }
            return null;
        }

        internal static FileStream getFileOut(string file_name)
        {
            try
            {
                FileStream fileOut = new FileStream(file_name, FileMode.Create, FileAccess.Write);
                return fileOut;
            }

            catch (Exception a)
            {

                Console.WriteLine(a.Message);

            }
            return null;
        }
    }

    internal class files_binary
    {

        static string stanFileInt = "abs.txt";
        static string stanFileOut = "_abs.txt";


        static void printFile(string file_name)
        {
            StreamReader file = new StreamReader(file_name);

            Console.WriteLine(file.ReadToEnd());
        }

        internal static void task_1()
        {
            FileStream fileOut = _boom.getFileOut(stanFileOut);

            int[] array = _mass.get_mass_randElem(20, -100, 100);

            _mass.print("Mass elem:");
            _mass.print_massInt(array);

            foreach (int i in array)
            {
                if (i < 0)
                {
                    fileOut.WriteByte((byte)i);
                }
            }

            fileOut.Close();

            printFile(stanFileOut);
        }

        internal static void task_2()
        {
            FileStream fileOut = _boom.getFileOut(stanFileOut);

            double[] array = new double[] { 90.20, 10.10, 23, 409.34 };
            foreach (double i in array)
            {
                fileOut.WriteByte((byte)i);
            }

            fileOut.Close();

            printFile(stanFileOut);
        }

        internal static void task_3()
        {
            FileStream fileOut = _boom.getFileOut(stanFileOut);

            string str = Console.ReadLine();
            string numbers = "1234567890";

            foreach (char i in str)
            {
                if (numbers.Contains(i) == false)
                {
                    fileOut.WriteByte((byte)i);
                }
            }
            fileOut.Close();
            printFile(stanFileOut);


        }
    }

    internal class files
    {

        static string standFile = "boom.txt";

        internal static void task_1() {

            StreamReader file = new StreamReader(standFile);

            string[] array = file.ReadToEnd().Split();

            file.Close();

            int n = 0;

            foreach (string s in array)
            {
                if (s[0] == s[s.Length - 1] && s.Length >= 2) { n++; }
            }

            Console.WriteLine(n);

        }

        internal static void task_2()
        {

            StreamReader file = new StreamReader(standFile);

            string[] array = file.ReadToEnd().Split();

            file.Close();

            int n = 0, max_len = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > max_len) { n = i; max_len = array[i].Length; }
            }

            Console.WriteLine($"{n} {max_len}");

        }

        internal static void task_3()
        {

            StreamReader file = new StreamReader(standFile);

            string[] array = file.ReadToEnd().Split();

            file.Close();

            int k = 0;

            Console.WriteLine("Write k:");
            k = int.Parse(Console.ReadLine());

            StringBuilder str = new StringBuilder();

            foreach (string s in array)
            {
                if (s.Length > k) {
                    str.Append(s[k]); 
                }
            }

            Console.WriteLine(str.ToString());

        }

        internal static void task_4()
        {

            StreamReader file = new StreamReader(standFile);

            FileStream file_out = _boom.getFileOut("new_" + standFile);

            string str = file.ReadToEnd();

            file.Close();

            for (int n = 0; n <= str.Length; n += 2)
            {
                file_out.WriteByte((byte)str[n]);
            }

            file_out.Close();

        }
    }
}
