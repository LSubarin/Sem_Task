﻿// Задача 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

System.Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());          // вводим первое число
System.Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());          // вводим второе число

if (numA % numB == 0)                                       // Если отаток от деления первого числа на второе равен нулю
{
    System.Console.WriteLine(numA + " кратно " + numB);      //Выводим этот результат
}
else                                                     //Иначе
{
    System.Console.WriteLine(numA + " не кратно " + numB + " - остаток от деления: " + numA%numB);   //Выводим этот результат
}


