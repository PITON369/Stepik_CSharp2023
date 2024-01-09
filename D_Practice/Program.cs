// See https://aka.ms/new-console-template for more information
using D_Practice;
using System.Runtime.CompilerServices;

//Homework0801
/*
 Разработать класс представляющий комплексное число. Класс должен содержать два свойства для представления вещественной (double) и мнимой части (double). 
Сделать так, чтобы создать экземпляр класса без передачи соответствующих аргументов было невозможно.
 */
//var homework0801 = new Homework0801();
//double result = homework0801.Foo(1.0,2.0,3.0);
//Console.WriteLine($"Homework0801. result = {result}");

//Homework0803
/*
 Разработать игру "угадай число".

Один из игроков загадывает число от 0 до 100 (по умолчанию), а второй пытается угадать за лимитированное число попыток (5 по умолчанию). 
Когда второй игрок делает предположение о загаданном числе, первый игрок сообщает о том угадано ли число, меньше ли оно загаданного, или 
больше. Если угадано - игра завершена. Если меньше или больше загаданного, то второй игрок сужает область поиска и продолжает пытаться 
угадывать. Так происходит до тех пор пока либо число не угадано, либо исчерпано кол-во попыток.

Загадывать может как человек, так и машина. Соответственно и угадывать может как человек, так и машина. Это значит, что надо реализовать 
два режима игры: когда загадывает машина и когда загадывает человек.

Если загадывает человек, а угадывает машина, то нужно сделать так, чтобы машина пыталась угадать число, используя алгоритм бинарного поиска.

Пример бинарного поиска загаданного числа: загадано число 18, при условии, что число загадывалось в диапазоне от 0 до 100. Игрок каждый 
раз берёт середину, т.е. на первой попытке предполагает число 50. Первый игрок говорит, что загаданное число меньше. Значит число лежит 
между 0 и 50. Тогда второй игрок снова делит диапазон на 2 и предполагает 25. Первый игрок говорит, что загаданное число меньше. Значит 
число между 0 и 25. Тогда второй игрок снова делит диапазон на 2 и предполагает 12 (дробную часть мы просто срезаем). Первый игрок 
говорит, что загаданное число больше. Значит число лежит в диапазоне между 12 и 25. Второй игрок делить диапазон на два и предполагает 18. 
Первый игрок говорит, что число угадано. Игра завершена.

На каждой попытке , благодаря так стратегии, диапазон поиска сужается в два раза. Это и есть суть бинарного поиска. В конце игры выводится 
информация о том достигнута ли победа или нет. Конечно же, будет необходимо реализовать диалог между игроками.
 */
while (true)
{
    Console.WriteLine($"Homework0803. Set game. Who choose number Person or PC?");
    string gameMode = Console.ReadLine();
    if (gameMode == "Person")
    {
        try
        {
            Console.WriteLine($"Choose number.");
            int answer = int.Parse(Console.ReadLine());
            Console.WriteLine($"Choose counter.");
            int count = int.Parse(Console.ReadLine());
            var homework0803 = new Homework0803(count, answer);
            if (homework0803.TryFindNumber(answer))
                Console.WriteLine("PC win");
            else
                Console.WriteLine("PC loose");
        }
        catch
        {
            Console.WriteLine("Use only numbers.");
        }
    }
    else if (gameMode == "PC")
    {
        var homework0803 = new Homework0803();
        Console.WriteLine($"You have {homework0803.Count} tries. Write number:");
        for (int i = 0; i < homework0803.Count; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == homework0803.Answer)
            {
                Console.WriteLine("You win!");
                break;
            }
            else if (number > homework0803.Answer)
                Console.WriteLine("Your number bigger than PC number.");
            else
                Console.WriteLine("Your number smaller than PC number.");

            if (i == homework0803.Count)
            {
                Console.WriteLine("You loose!");
                break;
            }
            Console.WriteLine($"You have {homework0803.Count} tries. Write number:");
        }
    }
    else
        Console.WriteLine("Write \"Person\" or \"PC\"");
}