// Задача №18. Напишите программу, которая по заданному номеру четверти
// показывает возможный диапазон координат точек (x и y) в этой четверти. 


System.Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
// index                    0              1               2               3                 4 
string[] strArray = { "X > 0, Y > 0", "X < 0, Y > 0", "X < 0, Y < 0", "X > 0, Y < 0","Такой четверти нет"};

if(quarter > 0 && quarter < 5)
{
    System.Console.WriteLine(strArray[quarter-1]);
}
else
{
    System.Console.WriteLine(strArray[4]);
}



// if(quarter == 1)
// {
//     System.Console.WriteLine(strArray[0]);
// }
// else if (quarter == 2)
// {
//     System.Console.WriteLine(strArray[1]);
// }
// else if (quarter == 3)
// {
//     System.Console.WriteLine(strArray[2]);
// }
// else if (quarter == 4)
// {
//     System.Console.WriteLine(strArray[3]);
// }
// else
// {
//     System.Console.WriteLine(strArray[4]);
// }

// {
//     System.Console.WriteLine("X > 0, Y > 0");
// }
// else if (quarter == 2)
// {
//     System.Console.WriteLine("X < 0, Y > 0");
// }
// else if (quarter == 3)
// {
//     System.Console.WriteLine("X < 0, Y < 0");
// }
// else if (quarter == 4)
// {
//     System.Console.WriteLine("X > 0, Y < 0");
// }
// else
// {
//     System.Console.WriteLine("Такой четверти нет");
// }

