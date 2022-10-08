// Является ли число квадратом другого

Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

    if(Math.Sqrt(a) == b) 
    {
        Console.WriteLine("Первое число является квадратом второго");
    }
    else 
    {
        Console.WriteLine("Первое число не является квадратом второго");
    }
     if(Math.Sqrt(b) == a) 
    {
        Console.WriteLine("Второе число является квадратом первого");
    }
    else 
    {
        Console.WriteLine("Второе число является квадратом первого");
    }