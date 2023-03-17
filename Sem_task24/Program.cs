/* Задача №24. Напишите прогшрамму которая на входе
принимает число А, а на выходе показывает сумму чисел
от 1 до А
*/
System.Console.WriteLine("Введите число А: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for(int i = 1; i <= number; i++)
{
    sum+=i;
}
System.Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");