// При вводе четверти показать диапазон координат
Console.WriteLine("Введите номер четверти");
int a = int.Parse(Console.ReadLine());
if(a == 1) Console.WriteLine("Диапазон координат данной четверти X>0, Y>0");
else if(a == 2) Console.WriteLine("Диапазон координат данной четверти X<0, Y>0");
else if(a == 3) Console.WriteLine("Диапазон координат данной четверти X<0, Y<0");
else if(a == 4) Console.WriteLine("Диапазон координат данной четверти X>0, Y<0");
else Console.WriteLine("Ошибка, такой четверти не существует");