// Задача №21. Напишите программу, которая на входе принимает координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// Математические операторы 

// System.Console.WriteLine(Math.Pow(3,2));                 // (Math.Pow(a, b) - Возводит a в степень b
// System.Console.WriteLine(Math.Sqrt(2));                  // (Math.Sqrt(c)) - Квадратный корень с
// System.Console.WriteLine(Math.Round(Math.Sqrt(2), 3));   // (Math.Round(e, d)) - Округление числа e до d знака после запятой

// int arr = Array.ConvertAll(Console.ReadLine().Split(" "). int.Parse);
// for (int = 0; i < arr.Lenght; i++)
// {
//     System.Console.WriteLine(arr[i]+ " ");
// }

System.Console.WriteLine("Введите координату x точки А:");
int[] coordsA = new int[2];
coordsA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки А:");
coordsA[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату x точки B:");
int[] coordsB = new int[2];
coordsB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки B:");
coordsB[1] = Convert.ToInt32(Console.ReadLine());

int result1 = (int)Math.Pow(coordsB[0]-coordsA[0], 2);
int result2 = (int)Math.Pow(coordsB[1]-coordsA[1], 2);
double result3 = Math.Sqrt(result1+result2);

System.Console.WriteLine(Math.Round(result3,3));