using System.Net;

while (true)
{
    Console.WriteLine("как вас зовут?");
    string? name = Console.ReadLine();
    Console.WriteLine($"привет, {name}!");
    break;
    if (string.IsNullOrWhiteSpace(name)) ; // или if (name == "exit")
     
}
Console.WriteLine("хотите посчитать четность числа? (да/нет)");
if (Console.ReadLine()?.Trim().ToLower() == "да")
{
    Console.WriteLine("введите число:");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if (number % 2 == 0)
            Console.WriteLine($"число {number} четное");
        else
            Console.WriteLine($"число {number} нечетное");
    }
    else
    {
        Console.WriteLine("это не число");
    }
}
else
{
    Console.WriteLine("вы отказались от проверки четности числа");
}
Console.WriteLine("играть еще? (да/нет)");
string? answer = Console.ReadLine()?.Trim().ToLower();
if (answer == "нет")
{
    Console.WriteLine("вы отказались от игры");
    return;
}
else if (answer == "да")
{
    Console.WriteLine("играем снова!");
}
while (true)
{
    Console.WriteLine("введите число:");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if (number % 2 == 0)
            Console.WriteLine($"число {number} четное");
        else
            Console.WriteLine($"число {number} нечетное");
    }
    else
    {
        Console.WriteLine("это не число");
    }
    Console.WriteLine("играть еще? (да/нет)");
    answer = Console.ReadLine()?.Trim().ToLower();
    if (answer == "нет")
    {
        Console.WriteLine("вы отказались от игры");
        break;
    }
    else if (answer == "да")
    {
        Console.WriteLine("играем снова!");
    }
}

//первая программа моя
