// Задача 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());          // вводим число

if(num%7 ==0 && num%23 ==0)                             // Если остаток при делении на 7 и на 23 равен нулю
{
    System.Console.WriteLine("Да, число "+num+" кратно 7 и 23");
}
else
{
    System.Console.WriteLine("Нет, число "+num+" не кратно 7 и 23");
}