// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X не равен 0 и Y не равен нулю и выдает номер четверти плоскостей,
// в которой находится эта точка.

int[] coords = new int[2];


System.Console.Write("Введите X: ");
coords[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Y: ");
coords[1] = Convert.ToInt32(Console.ReadLine());

if(coords[0] > 0 && coords[1] > 0)
{
    System.Console.WriteLine("точка находится в первой четверти");
}
else if(coords[0] < 0 && coords[1] > 0)
{
    System.Console.WriteLine("точка находится во второй четверти");
}
else if(coords[0] < 0 && coords[1] < 0)
{
    System.Console.WriteLine("точка находится в третьей четверти");
}
else if(coords[0] > 0 && coords[1] < 0)
{
    System.Console.WriteLine("точка находится в четвертой четверти");
}
else 
{
    System.Console.WriteLine("точка находится на осях");
}