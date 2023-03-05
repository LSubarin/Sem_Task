// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

Random rand = new Random();
int randNumber = rand.Next(10, 100);    // Генерируем случайное число из диапазона [10,100)
System.Console.WriteLine(randNumber);   // Выводим в консоль полученное число   

int leftNumber = randNumber / 10;       // Получаем левую цифру числа (Целое от деления на 10)
int rightNumber = randNumber % 10;      // получаем правую цифру числа (Остаток от деления на 10)
if (leftNumber > rightNumber)            // Если левое больше правого
{
    System.Console.WriteLine($"{leftNumber} > {rightNumber}"); // Выводим - левое больше правого
}
else if (rightNumber > leftNumber)       // Иначе если правое больше левого
{
    System.Console.WriteLine($"{rightNumber} > {leftNumber}"); // выводим - правое больше левого
}
else                                   // Иначе 
{
    System.Console.WriteLine("Числа равны"); // выводим - Числа равны
}
