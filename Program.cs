using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{

    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лаборатораня №1 - Инкапсуляция");
            Console.WriteLine("Выполнил Авраам Линкольн");

            //1.1
            Complex a = new Complex() { Real = 3, Imaginary = -0.5 };
            Complex b = new Complex() { Real = 2, Imaginary = 0.8 };

            //+
            Complex addition = a + b;

            //-
            Complex subtraction = a - b;

            Console.WriteLine("a = {0}", addition);
            Console.WriteLine("b = {0}", subtraction);

            //*
            Complex multiplication = a * b;

            // /
            Complex division = a / b;

            Console.WriteLine("a = {0}", multiplication);
            Console.WriteLine("b = {0}", division);


            Console.WriteLine(a);

            Console.WriteLine();
            //1.2
            Student student1 = new Student("Artyom", "Lunyov", "Rusiy", 20);
            Student student2 = new Student("Anton", "Vostrikov", "Black", 21);
            Student result = Student.Add(student1, student2);

            Console.WriteLine("Name: " + result.Name);
            Console.WriteLine("Surname: " + result.Surname);
            Console.WriteLine("Color hair: " + result.Colorhair);
            Console.WriteLine("Age: " + result.Age);


        }
    }
}