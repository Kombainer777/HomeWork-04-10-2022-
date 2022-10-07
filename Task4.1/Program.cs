// Найти расстояние между точками в 2D системе координат. 
Console.WriteLine("Введите Координату X для ПЕРВОЙ точки");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Координату Y для ПЕРВОЙ точки");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Координату X для ВТОРОЙ точки");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Координату Y для ВТОРОЙ точки");
double y2 = double.Parse(Console.ReadLine());

double S = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
Console.WriteLine("Расстояние между заданными точками равно: " +S);