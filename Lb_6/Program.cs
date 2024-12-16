using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public double AverageGrade { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Ім'я: {FirstName}, Прізвище: {LastName}, Вік: {Age}, Середній бал: {AverageGrade}");
    }

    public bool IsExcellent()
    {
        return AverageGrade >= 90;
    }
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public int Pages { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Назва: {Title}, Автор: {Author}, Рік видання: {Year}, Кількість сторінок: {Pages}");
    }

    public bool IsModern()
    {
        return Year > 2000;
    }

    public bool IsBig()
    {
        return Pages > 300;
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        var students = new List<Student>
        {
            new Student { FirstName = "Олег", LastName = "Іваненко", Age = 19, AverageGrade = 92 },
            new Student { FirstName = "Марія", LastName = "Петренко", Age = 20, AverageGrade = 85 },
            new Student { FirstName = "Анна", LastName = "Сидорова", Age = 21, AverageGrade = 95 }
        };

        Console.WriteLine("Список студентів:");
        foreach (var student in students)
        {
            student.PrintInfo();
        }

        Console.WriteLine("\nСтуденти-відмінники:");
        foreach (var student in students.Where(s => s.IsExcellent()))
        {
            student.PrintInfo();
        }

        var books = new List<Book>
        {
            new Book { Title = "Мистецтво війни", Author = "Сунь Цзи", Year = 2005, Pages = 320 },
            new Book { Title = "Гаррі Поттер і філософський камінь", Author = "Дж. К. Роулінг", Year = 1997, Pages = 223 },
            new Book { Title = "Програмування на C#", Author = "Джон Сміт", Year = 2018, Pages = 450 },
            new Book { Title = "Іліада", Author = "Гомер", Year = -800, Pages = 500 }
        };

        Console.WriteLine("\nСписок книг:");
        foreach (var book in books)
        {
            book.PrintInfo();
        }

        Console.WriteLine("\nСучасні книги (видані після 2000 року):");
        foreach (var book in books.Where(b => b.IsModern()))
        {
            book.PrintInfo();
        }

        Console.WriteLine("\nКниги з кількістю сторінок більше 300:");
        foreach (var book in books.Where(b => b.IsBig()))
        {
            book.PrintInfo();
        }
    }
}
