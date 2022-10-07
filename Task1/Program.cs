// Узнать является ли день недели выходным
// Снова базируемся на октябре месяце

int[] sat =  {1, 8, 15, 22, 29};
int[] sun =  {2, 9, 16, 23, 30};
Console.WriteLine("Введите число месяца октября (31 день)");
int a = int.Parse(Console.ReadLine());

if(sat.Contains(a))
    {
     Console.WriteLine("Выходной");   
    }
   else if(sun.Contains(a))
   {
    Console.WriteLine("Выходной");
   }
   else
   {
    Console.WriteLine("Будний день");
   }
