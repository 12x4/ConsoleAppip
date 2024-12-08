using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            task2_5();
        }

        static void task1_1()
        {
            Point t = new Point();
            double r = 9;

            if (t.x * t.x + t.y * t.y <= r && t.y >= 0)
            {
                if (t.x * t.x + t.y * t.y < r) Console.WriteLine("Yes");
                else Console.WriteLine("On the border");
            }
            else { Console.WriteLine("No"); }
        }

        static void task1_2()
        {
            Point t = new Point();
            double r = 81;

            if (t.x * t.x + t.y * t.y <= r && t.x >= 0)
            {
                if (t.x * t.x + t.y * t.y < r) Console.WriteLine("Yes");
                else Console.WriteLine("On the border");
            }
            else { Console.WriteLine("No"); }
        }

        static void task1_3()
        {
            Point t = new Point();
            double R = 100, r = 25;

            if (t.x * t.x + t.y * t.y <= R && t.x * t.x + t.y * t.y >= r && t.y >= 0)
            {
                if (t.x * t.x + t.y * t.y < R && t.x * t.x + t.y * t.y > r) Console.WriteLine("Yes");
                else Console.WriteLine("On the border");
            }
            else { Console.WriteLine("No"); }
        }

        static void task1_4()
        {
            Point t = new Point();
            double R = 64, r = 9;

            if (t.x * t.x + t.y * t.y <= R && t.x * t.x + t.y * t.y >= r && t.x <= 0)
            {
                if (t.x * t.x + t.y * t.y < R && t.x * t.x + t.y * t.y > r) Console.WriteLine("Yes");
                else Console.WriteLine("On the border");
            }
            else { Console.WriteLine("No"); }
        }

        static void task1_5()
        {
            Point t = new Point();
            double R = 49, r = 9;

            if (t.x * t.x + t.y * t.y <= R && t.x * t.x + t.y * t.y >= r)
            {
                if (t.x * t.x + t.y * t.y < R && t.x * t.x + t.y * t.y > r) Console.WriteLine("Yes");
                else Console.WriteLine("On the border");
            }
            else { Console.WriteLine("No"); }
        }

        static void task1_6()
        {
            Point t = new Point();
            double R = 625, r = 225;

            if (t.x * t.x + t.y * t.y >= R || t.x * t.x + t.y * t.y <= r)
            {
                if (t.x * t.x + t.y * t.y > R || t.x * t.x + t.y * t.y < r) Console.WriteLine("Yes");
                else Console.WriteLine("On the border");
            }
            else { Console.WriteLine("No"); }
        }

        static void task1_7()
        {
            Point t = new Point();
            double R = 225, r = 0;

            if (t.x * t.x + t.y * t.y <= R && t.x * t.x + t.y * t.y >= r && t.y >= 0 && Math.Abs(t.y) >= Math.Abs(t.x))
            {
                if (t.x * t.x + t.y * t.y < R && t.x * t.x + t.y * t.y > r && Math.Abs(t.x) != Math.Abs(t.y)) Console.WriteLine("Yes");
                else Console.WriteLine("On the border");
            }
            else { Console.WriteLine("No"); }
        }

        static void task1_8()
        {
            Point t = new Point();
            double R = 625, r = 0;

            if (t.x * t.x + t.y * t.y <= R && t.x * t.x + t.y * t.y >= r && t.y <= 0 && Math.Abs(t.y) >= Math.Abs(t.x))
            {
                if (t.x * t.x + t.y * t.y < R && t.x * t.x + t.y * t.y > r && Math.Abs(t.x) != Math.Abs(t.y)) Console.WriteLine("Yes");
                else Console.WriteLine("On the border");
            }
            else { Console.WriteLine("No"); }
        }

        static void task2_1()
        {
            Console.Write("Введите порядковый номер дня недели (от 1 до 7): ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            string dayName;

            switch (dayNumber)
            {
                case 1:
                    dayName = "Понедельник";
                    break;
                case 2:
                    dayName = "Вторник";
                    break;
                case 3:
                    dayName = "Среда";
                    break;
                case 4:
                    dayName = "Четверг";
                    break;
                case 5:
                    dayName = "Пятница";
                    break;
                case 6:
                    dayName = "Суббота";
                    break;
                case 7:
                    dayName = "Воскресенье";
                    break;
                default:
                    dayName = "Неверный ввод! Порядковый номер дня недели должен быть от 1 до 7.";
                    break;
            }

            Console.WriteLine(dayName);

        }

        static void task2_2()
        {
            Console.Write("Введите порядковый номер месяца (от 1 до 12): ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            if (monthNumber < 1 || monthNumber > 12)
            {
                Console.WriteLine("Ошибка ввода! Введен неверный номер месяца.");
            }
            else
            {
                // Количество месяцев в году
                const int monthsInYear = 12;

                // Вычисляем количество месяцев, оставшихся до конца года
                int remainingMonths = monthsInYear - monthNumber;

                Console.WriteLine($"До конца года осталось {remainingMonths} месяц(ев).");
            }
        }

        static void task2_3()
        {
            Console.Write("Введите количество баллов (от 0 до 100): ");
            int score = Convert.ToInt32(Console.ReadLine());

            string grade;

            if (score >= 90 && score <= 100)
            {
                grade = "Отлично";
            }
            else if (score >= 70 && score < 90)
            {
                grade = "Хорошо";
            }
            else if (score >= 50 && score < 70)
            {
                grade = "Удовлетворительно";
            }
            else if (score >= 0 && score < 50)
            {
                grade = "Неудовлетворительно";
            }
            else
            {
                grade = "Некорректное значение баллов!";
            }

            Console.WriteLine(grade);
        }

        static void task2_4()
        {
            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            string animal = "";

            // Восточный календарь начинается с 1924 года
            int cycleStartYear = 1924;
            int cyclePosition = (year - cycleStartYear) % 12;

            switch (cyclePosition)
            {
                case 0:
                    animal = "Крыса";
                    break;
                case 1:
                    animal = "Бык";
                    break;
                case 2:
                    animal = "Тигр";
                    break;
                case 3:
                    animal = "Кролик";
                    break;
                case 4:
                    animal = "Дракон";
                    break;
                case 5:
                    animal = "Змея";
                    break;
                case 6:
                    animal = "Лошадь";
                    break;
                case 7:
                    animal = "Овца";
                    break;
                case 8:
                    animal = "Обезьяна";
                    break;
                case 9:
                    animal = "Петух";
                    break;
                case 10:
                    animal = "Собака";
                    break;
                case 11:
                    animal = "Свинья";
                    break;
            }

            Console.WriteLine($"Животное, символизирующее {year} год по восточному календарю: {animal}");
        }

        static void task2_5()
        {
            Console.Write("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            string category;

            if (age < 1)
            {
                category = "Младенец";
            }
            else if (age >= 1 && age <= 11)
            {
                category = "Ребенок";
            }
            else if (age >= 12 && age <= 15)
            {
                category = "Подросток";
            }
            else if (age >= 16 && age <= 25)
            {
                category = "Юноша";
            }
            else if (age >= 26 && age <= 70)
            {
                category = "Мужчина";
            }
            else if (age > 70)
            {
                category = "Старик";
            }
            else
            {
                category = "Некорректный возраст!";
            }

            Console.WriteLine(category);
        }



    }
}
