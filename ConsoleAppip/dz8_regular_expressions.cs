using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using dz6;

namespace dz8
{
    public class helpMe : dz6_mass
    {
        public static String getStrRand()
        {
            String[] strArr = "Эта book адресована всем, кто изучает русский язык. Но состоит она не из правил, упражнений и учебных текстов. Для этого созданы другие замечательные учебники.\r\n\r\nУ этой книги совсем иная задача. Она поможет вам научиться не только разговаривать, но и размышлять по-русски. Книга, которую вы держите в руках, составлена из афоризмов и размышлений великих мыслителей, писателей, поэтов, философов и общественных деятелей различных эпох. Их мысли - о тех вопросах, которые не перестают волновать человечество.\r\n\r\nВы можете соглашаться или не соглашаться с тем, что прочитаете в этой книге. Возможно, вам покажется, что какие-то мысли уже устарели. Но вы должны обязательно подумать и обосновать, почему вы так считаете.\r\n\r\nА еще вы узнаете и почувствуете, как прекрасно звучат слова любви, сострадания, мудрости и доброты на русском языке.".Split('.');
            var rand = new Random();
            return strArr[rand.Next(0, strArr.Length - 1)];
        }

    }

    public class modul_1: helpMe
    {
        public static void task_1()
        {
            String str = getStrRand();
            print(str);
            Regex reG = new Regex(@"\w(\w*)");

            MatchCollection matchCollection = reG.Matches(str);

            if (matchCollection.Count > 0)
            {
                print("Yes");
            }
            else
            {
                print("No");
            }
        }

        public static void task_2()
        {
            String str = getStrRand();
            print(str);
            Regex reG = new Regex(@"\w(\w*)");

            print("write n:");
            int n = Int32.Parse((Console.ReadLine()));

            MatchCollection matchCollection = reG.Matches(str);

            if (matchCollection.Count > 0)
            {
                foreach (Match match in matchCollection) {
                    if (match.Value.Length == n)
                    {
                        print(match.Value);
                    }                
                }
            }
        }

        public static void task_3()
        {
            String str = getStrRand();
            print(str);
            Regex reG = new Regex(@"(\w?\s?)");

            MatchCollection matchCollection = reG.Matches(str);

            if (matchCollection.Count > 0)
            {
                foreach (Match match in matchCollection)
                {
                    Console.Write(match.Value);
                }
            }
        }

        public static void task_4()
        {
            String str = getStrRand().ToLower();
            print(str);
            Regex reG = new Regex(@"\b[уеыаоэяи]\w*");

            MatchCollection matchCollection = reG.Matches(str);

            if (matchCollection.Count > 0)
            {
                foreach (Match match in matchCollection)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }

        public static void task_5()
        {
            String str = getStrRand().ToLower();
            print(str);

            //Regex reG = new Regex(@"\s[уеыаоэяи]\w*");

            String boom = Regex.Replace(str, @"[qwertyuiopasdfghjklzxcvbnm]\w*", ":");

            print(boom);
        }

        public static void task_6()
        {
            String str = "-10,0 20. reet 900";
            print(str);
            Regex reG = new Regex(@"[-]?(\d+)[,]?(\d*)");

            MatchCollection matchCollection = reG.Matches(str);
            double n = 0;

            if (matchCollection.Count > 0)
            {
                foreach (Match match in matchCollection)
                {
                    Console.WriteLine("-  " + match.Value + "  -");
                    n += Convert.ToDouble(match.Value);
                }
            }
            Console.WriteLine(n);
        }

        public static void task_7()
        {
            String str = "77-77-77 reset 777-777 boom 777-77-77";
            print(str);
            Regex reG = new Regex(@"\d+-\d+-?\d*");

            MatchCollection matchCollection = reG.Matches(str);

            if (matchCollection.Count > 0)
            {
                foreach (Match match in matchCollection)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }

        public static void task_8()
        {
            String str = " 31.12.2010 reset 10.1.1999 boom 2.10.1950";
            print(str);
            Regex reG = new Regex(@"(31|30|[1-2]\d|\D\d).(12|11|10|\D\d).(1900|19\d{2}|200/d|2010)");

            MatchCollection matchCollection = reG.Matches(str);

            if (matchCollection.Count > 0)
            {
                foreach (Match match in matchCollection)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }

        public static void task_9()
        {
            String str = " 192.1.204.216 reset 255.255.255.0 boom 192.168.256.149";
            print(str);
            Regex reG = new Regex(@"(1?\d?\d|2[0-5][0-6])\.(1?\d?\d|2[0-5][0-6])\.(1?\d?\d|2[0-5][0-6])\.(1?\d?\d|2[0-5][0-6])");

            MatchCollection matchCollection = reG.Matches(str);

            if (matchCollection.Count > 0)
            {
                foreach (Match match in matchCollection)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }

        public static void task_10()
        {
            String str = "01:59 reset 255.255.255.0 boom 192.168.256.149";
            print(str);
            Regex reG = new Regex(@"(0\d|1\d|2[0-3])\:(0\d|1\d|2\d|3\d|4\d|5\d)");

            MatchCollection matchCollection = reG.Matches(str);

            if (matchCollection.Count > 0)
            {
                foreach (Match match in matchCollection)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}
