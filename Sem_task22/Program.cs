// Задача №22. Напишите программу которая принимает на вход число (N)
// и выдает таблицк квадратов чисел от 1 до N.

System.Console.WriteLine("введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine())); // Math.Abs - делает из отрицательного числа положительное

for (int i = 1; i <= number; i++)
{
    Console.Write(Math.Pow(i, 2) + " ");
}
