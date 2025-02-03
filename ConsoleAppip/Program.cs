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

using Class_r1;
using Class_r2;
using IS;



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

            //Interface_structurs_2.testTask2();
            //Interface_structurs.testTask1();

        }

        //Для демонстрации класса Person
        static void testPerson()
        {
            // Создание базы персон
            List<Persona> persons = new List<Persona>
        {
            new Applicant { LastName = "Иванов", BirthDate = new DateTime(2005, 3, 15), Faculty = "Информатика" },
            new Student { LastName = "Петров", BirthDate = new DateTime(2003, 7, 22), Faculty = "Математика", Course = 2 },
            new Teacher { LastName = "Сидорова", BirthDate = new DateTime(1980, 11, 5), Faculty = "Физика", Position = "Доцент", Experience = 15 }
        };

            // Вывод информации о всех персонах
            Console.WriteLine("Информация о всех персонах:");
            foreach (var person in persons)
            {
                person.DisplayInfo();
            }

            // Поиск персон в заданном диапазоне возраста
            Console.WriteLine("\nВведите диапазон возраста (от и до):");
            int minAge = int.Parse(Console.ReadLine());
            int maxAge = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nПерсоны в возрасте от {minAge} до {maxAge} лет:");
            foreach (var person in persons)
            {
                int age = person.CalculateAge();
                if (age >= minAge && age <= maxAge)
                {
                    person.DisplayInfo();
                }
            }
        }

        //Для демонстрации класса database
        static void testDatabase()
        {
            // 3. Создаем базу данных (массив) из n записей
            PhoneDirectory[] database = new PhoneDirectory[]
            {
            new Person("Иванов", "ул. Ленина, 10", "123-456-789"),
            new Organization("ООО Ромашка", "ул. Пушкина, 5", "987-654-321", "987-654-322", "Петров"),
            new Friend("Сидоров", "ул. Гагарина, 15", "555-555-555", new DateTime(1990, 5, 15))
            };

            // Выводим полную информацию из базы данных
            Console.WriteLine("Полная информация из базы данных:");
            foreach (var entry in database)
            {
                entry.PrintInfo();
            }

            // Организуем поиск по фамилии
            Console.Write("\nВведите фамилию для поиска: ");
            string searchLastName = Console.ReadLine();

            Console.WriteLine("\nРезультаты поиска:");
            foreach (var entry in database)
            {
                if (entry.MatchesCriteria(searchLastName))
                {
                    entry.PrintInfo();
                }
            }
        }

        // для демонстрации класса RegexTwo
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

        // для демонстрации класса StringTwo
        public static void testStringTwo()
        {
            stringTwo _string = new stringTwo(10);
            _string = "Dyrak";

            stringTwo _string_new = new stringTwo(10);
            _string_new.Word = "Dyrak";

            Console.WriteLine(_string & _string_new);

            Console.WriteLine(_string);

        }

        // для демонстрации класса DateTimeTwo
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
