// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Threading.Channels;

Console.WriteLine("Start");
//Homework0302();
//Homework0310();
//Homework0312();
//Homework0314();
//Homework0316();

 //$ - интерполяция
var newList = new List<int>() { 1, 2, 3, 4 };
int x = newList.Capacity;
Console.WriteLine($"x = {x}");
newList.Add(7);
x = newList.Capacity;
Console.WriteLine($"x = {x}");
Console.ReadLine();

var stack = new Stack<int>();
stack.Push(3);
stack.Push(2);
stack.Push(1);

foreach(var cur in stack)
{
    Console.WriteLine(cur);
}

static void Homework0302()
{
    //Max int
    Console.WriteLine("Input 2 numbers.");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());

    string answer = a > b ? $"{a}" : $"{b}";

Console.WriteLine("Max int is " + answer);
}

static void Homework0310()
{
    //Fibonacci numbers
    Console.WriteLine("How many Fibonacci number do you need to show? Number must be an integer greater than 0 and less than 93.");
    int number = int.Parse(Console.ReadLine());
    long a0, a1 = 0, m = 1;
    long[] mas = new long[number];
    for (int i = 0; i < number; i++)
    {
        mas[i] = m;

        a0 = a1;
        a1 = m;        
        m += a0;        
    }
    foreach (int cur in mas)
        Console.Write(cur + " ");
}

static void Homework0312()
{
    //Average calculation
    Console.WriteLine("Write 10 or less numbers. The numbers must be positive integers. To stop, type 0.");

    int[] numbers = new int[10];
    for (int i = 0; i < 10; i++)
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 0)
            break;
        else
            numbers[i] = n;
    }

    int sum = 0, count = 0;
    for (int i = 0; i < 10; i++)
    {
        if (numbers[i] == 0)
            break;
        else
        {
            if (numbers[i] % 3 == 0)
                sum += numbers[i];
            count++;
        }
    }
    double average = (double)sum / count;
    Console.WriteLine(average);
}

static void Homework0314()
{
    //Factorial without using recursive function
    Console.WriteLine("Enter a number to calculate factorial. Number must be higher than 0.");
    int fact = int.Parse(Console.ReadLine());
    long result = 1;
    for(int i = 1; i <= fact; i ++)
    {
        result *= i;
    }
    Console.WriteLine($"Factorial = {result}");
}

static void Homework0316()
{
    //Logging
    string password = "qwerty";
    string login = "johnsilver";
    int count = 0;
    while (count < 3)
    {
        Console.WriteLine("Enter login:");
        string userLogin = Console.ReadLine();

        Console.WriteLine("Enter password:");
        string userPassword = Console.ReadLine();

        if (userLogin == login && userPassword == password)
        {
            Console.WriteLine("Enter the System");
            break;
        }
        else
        {
            Console.WriteLine("Incorrect login or password!");
        }
        count++;
    }
    if (count == 3)
        Console.WriteLine("The number of available tries have been exceeded!");
}
