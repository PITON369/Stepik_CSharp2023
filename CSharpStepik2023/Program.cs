// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Homework0219();
Homework0221();
Homework0223();

static void Homework0219()
{
    //Tasks with input and output
    Console.WriteLine("Insert name");
    string name = Console.ReadLine();
    Console.WriteLine("Hello, " + name);
    Console.WriteLine("Insert first int");
    int i1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Insert second int");
    int i2 = int.Parse(Console.ReadLine());

    Console.WriteLine("First int = " + i1);
    Console.WriteLine("Second int = " + i2);
    int i0;
    i0 = i1;
    i1 = i2;
    i2 = i0;
    Console.WriteLine("Swap");
    Console.WriteLine("First int = " + i1);
    Console.WriteLine("Second int = " + i2);
    Console.WriteLine("Insert positive int");
    int i3 = int.Parse(Console.ReadLine());
    Console.WriteLine("Numbers of digits:" + (int)Math.Log10(i3) + 1);
}

static void Homework0221()
{
    //Heron's formula
    Console.WriteLine("Insert a, b, c");
    double a = int.Parse(Console.ReadLine());
    double b = int.Parse(Console.ReadLine());
    double c = int.Parse(Console.ReadLine());

    double p = 0.5 * (a + b + c);
    Console.WriteLine("Figure half area is " + p);
    double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

    Console.WriteLine("Figure area is " + S);
}

static void Homework0223()
{
    ////Tasks with input and output
    Console.WriteLine("Введите фамилию.");
    string surname = Console.ReadLine();
    Console.WriteLine("Введите имя.");
    string name = Console.ReadLine();
    Console.WriteLine("Введите возраст.");
    int age = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите вес в килограммах.");
    double weight = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите рост в метрах.");
    double height = double.Parse(Console.ReadLine());

    double imt = weight / (height * height);

    Console.WriteLine($"Your profile:");
    Console.WriteLine($"Full name: {surname} {name}");
    Console.WriteLine($"Age: {age}");
    Console.WriteLine($"Weight: {weight}");
    Console.WriteLine($"Height: {height}");
    Console.WriteLine($"Body Mass Index: {imt}");
}