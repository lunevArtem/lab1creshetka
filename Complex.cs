using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Complex
    {
        public double Real { get; set; } // действительная часть
        public double Imaginary { get; set; } // мнимая часть

        // конструктор по умолчанию
        public Complex()
        {
            Real = 0;
            Imaginary = 0;
        }

        // конструктор с параметрами
        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // перегрузка оператора сложения
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        // перегрузка оператора вычитания
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }

        // перегрузка оператора умножения
        public static Complex operator *(Complex c1, Complex c2)
        {
            double real = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary;
            double imaginary = c1.Real * c2.Imaginary + c2.Real * c1.Imaginary;
            return new Complex(real, imaginary);
        }

        // перегрузка оператора деления
        public static Complex operator /(Complex c1, Complex c2)
        {
            double denominator = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;
            double real = (c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / denominator;
            double imaginary = (c1.Imaginary * c2.Real - c1.Real * c2.Imaginary) / denominator;
            return new Complex(real, imaginary);
        }

        // перегрузка метода ToString для вывода комплексного числа
        public override string ToString()
        {
            return $"{Real} {(Imaginary >= 0 ? "+" : "-")} {Math.Abs(Imaginary)}i";
        }
    }
}