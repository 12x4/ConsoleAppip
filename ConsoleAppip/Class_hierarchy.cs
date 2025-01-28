using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_r1
{
    // Абстрактный класс Persona
    abstract class Persona
    {
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        // Метод для вывода информации о персоне
        public abstract void DisplayInfo();

        // Метод для вычисления возраста
        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthDate.Year;
            if (BirthDate.Date > today.AddYears(-age)) age--;
            return age;
        }
    }

    // Класс Абитуриент
    class Applicant : Persona
    {
        public string Faculty { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Абитуриент: {LastName}, Дата рождения: {BirthDate.ToShortDateString()}, Факультет: {Faculty}, Возраст: {CalculateAge()}");
        }
    }

    // Класс Студент
    class Student : Persona
    {
        public string Faculty { get; set; }
        public int Course { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Студент: {LastName}, Дата рождения: {BirthDate.ToShortDateString()}, Факультет: {Faculty}, Курс: {Course}, Возраст: {CalculateAge()}");
        }
    }

    // Класс Преподаватель
    class Teacher : Persona
    {
        public string Faculty { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Преподаватель: {LastName}, Дата рождения: {BirthDate.ToShortDateString()}, Факультет: {Faculty}, Должность: {Position}, Стаж: {Experience} лет, Возраст: {CalculateAge()}");
        }
    }

}

namespace Class_r2
{
    using System;

    // 1. Абстрактный класс PhoneDirectory
    abstract class PhoneDirectory
    {
        // Абстрактный метод для вывода информации
        public abstract void PrintInfo();

        // Абстрактный метод для проверки соответствия критерию поиска
        public abstract bool MatchesCriteria(string criteria);
    }

    // 2. Производный класс Person
    class Person : PhoneDirectory
    {
        public string LastName { get; set; } // Фамилия
        public string Address { get; set; } // Адрес
        public string PhoneNumber { get; set; } // Номер телефона

        public Person(string lastName, string address, string phoneNumber)
        {
            LastName = lastName;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Персона: {LastName}, Адрес: {Address}, Телефон: {PhoneNumber}");
        }

        public override bool MatchesCriteria(string criteria)
        {
            return LastName.Equals(criteria, StringComparison.OrdinalIgnoreCase);
        }
    }

    // 2. Производный класс Organization
    class Organization : PhoneDirectory
    {
        public string Name { get; set; } // Название
        public string Address { get; set; } // Адрес
        public string PhoneNumber { get; set; } // Номер телефона
        public string Fax { get; set; } // Факс
        public string ContactPerson { get; set; } // Контактное лицо

        public Organization(string name, string address, string phoneNumber, string fax, string contactPerson)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Fax = fax;
            ContactPerson = contactPerson;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Организация: {Name}, Адрес: {Address}, Телефон: {PhoneNumber}, Факс: {Fax}, Контактное лицо: {ContactPerson}");
        }

        public override bool MatchesCriteria(string criteria)
        {
            return ContactPerson.Equals(criteria, StringComparison.OrdinalIgnoreCase);
        }
    }

    // 2. Производный класс Friend
    class Friend : PhoneDirectory
    {
        public string LastName { get; set; } // Фамилия
        public string Address { get; set; } // Адрес
        public string PhoneNumber { get; set; } // Номер телефона
        public DateTime BirthDate { get; set; } // Дата рождения

        public Friend(string lastName, string address, string phoneNumber, DateTime birthDate)
        {
            LastName = lastName;
            Address = address;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Друг: {LastName}, Адрес: {Address}, Телефон: {PhoneNumber}, Дата рождения: {BirthDate.ToShortDateString()}");
        }

        public override bool MatchesCriteria(string criteria)
        {
            return LastName.Equals(criteria, StringComparison.OrdinalIgnoreCase);
        }
    }

}
