class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Colorhair { get; set; }
    public int Age { get; set; }
    public Student(string name, string surname, string hairColor, int age)
    {
        Name = name;
        Surname = surname;
        Colorhair = hairColor;
        Age = age;
    }

  
    public static Student Add(Student student1, Student student2)
    {
        // Входные цвета
        string color1 = "красный";
        string color2 = "желтый";

        // Смешивание цветов
        string result = MixColors(color1, color2);
        Console.WriteLine($"Смешение цветов {color1} и {color2} дает цвет {result}");
        // Вывод результата на консоль

        string name = student1.Name + " " + student2.Name;
        string surname = student1.Surname + " " + student2.Surname;
        string hairColor = student1.Colorhair + " " + student2.Colorhair;
        int age = student1.Age + student2.Age;

        return new Student(name, surname, hairColor, age);
    }
    static string MixColors(string color1, string color2)
    {

        // Проверка наличия входных цветов в списке разрешенных цветов
        if (color1 != "красный" && color1 != "желтый" && color1 != "синий")
        {
            throw new ArgumentException("Цвет 1 не является разрешенным цветом");
        }

        if (color2 != "красный" && color2 != "желтый" && color2 != "синий")
        {
            throw new ArgumentException("Цвет 2 не является разрешенным цветом");
        }

        // Смешивание цветов
        if (color1 == "красный" && color2 == "желтый" || color1 == "желтый" && color2 == "красный")
        {
            return "оранжевый";
        }
        else if (color1 == "красный" && color2 == "синий" || color1 == "синий" && color2 == "красный")
        {
            return "фиолетовый";
        }
        else if (color1 == "желтый" && color2 == "синий" || color1 == "синий" && color2 == "желтый")
        {
            return "зеленый";
        }
        else if (color1 == color2)
        {
            return color1;
        }
        else
        {
            throw new ArgumentException("Невозможно смешать эти два цвета");
        }
    }
}