using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace IS
{
    internal class Interface_structurs
    {

        public struct Toy
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int MinAge { get; set; }
            public int MaxAge { get; set; }

            public override string ToString()
            {
                return $"{Name}, {Price} руб., для детей от {MinAge} до {MaxAge} лет";
            }
        }

        public static void testTask1()
        {
            List<Toy> toys = new List<Toy>();

            // Чтение данных из файла
            using (StreamReader reader = new StreamReader("input.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    toys.Add(new Toy
                    {
                        Name = parts[0],
                        Price = decimal.Parse(parts[1]),
                        MinAge = int.Parse(parts[2]),
                        MaxAge = int.Parse(parts[3])
                    });
                }
            }

            // Фильтрация и сортировка
            int N = 3; // Минимальный возраст
            int M = 19; // Максимальный возраст


            List<Toy> filteredToys = new List<Toy>();

            foreach (var t in toys)
            {
                if (N >= t.MinAge && t.MaxAge >= M)
                {
                    filteredToys.Add(t);
                }
            }

            // Запись результата в файл
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                foreach (var toy in filteredToys)
                {
                    writer.WriteLine(toy.ToString());
                }
            }
        }

    }

    internal class Interface_structurs_2
    {

        public struct Student
        {
            public string FullName { get; set; }
            public int Course { get; set; }
            public string Group { get; set; }
            public double Result { get; set; }

            public override string ToString()
            {
                return $"{FullName}, {Course} курс, группа {Group}, результат: {Result}";
            }
        }

        public static void testTask2()
        {
            List<Student> students = new List<Student>();

            // Чтение данных из файла
            using (StreamReader reader = new StreamReader("input.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    students.Add(new Student
                    {
                        FullName = parts[0],
                        Course = int.Parse(parts[1]),
                        Group = parts[2],
                        Result = double.Parse(parts[3])
                    });
                }
            }

            // топ-3 результатов
            List<Student> topStudents = new List<Student>();

            List<double> array = new List<double>();

            foreach (var student in students)
            {
                if (!array.Contains(student.Result)) array.Add(student.Result);
            }

            array.Sort();

            if (array.Count >= 3)
            {
                array = array.GetRange(0, 3);
            }            

            foreach (var d in array)
            {
                foreach (var student in students)
                {
                    if (student.Result == d)
                    {
                        topStudents.Add(student);
                    }
                }
            }


            // Запись результата в файл
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                foreach (var student in topStudents)
                {
                    writer.WriteLine(student.ToString());
                }
            }
        }

    }
}
