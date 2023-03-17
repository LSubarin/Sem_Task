/* Задача №31. Задайте массив из 12 элементов, заполненный случайными числами
из диапазона [-9,9].Найдите сумму положительных и отрицательных
элементов массива
*/

// первое решение

// int[] array = new int[12];      // выделяем память под массив из 12 элементов
// Random rand = new Random();     // Создаем класс Random 

// for(int i = 0; i < array.Length; i++)   // Циклом проходим по элементам массива
// {
//     array[i] = rand.Next(-9, 10);       // и заполняем его случайными числами из диапазона [-9, 9] - 10 не входит
// }
// System.Console.WriteLine("[" + string.Join(", ", array) + "]"); // выводим полученный массив

// int sumPositive = 0;                // объявляем переменные sum (Для положительных и отрицательных результатов)
// int sumNegative = 0;
// for (int i=0; i<array.Length; i++)  // Проходимся циклом по элементам массива
// {
//     if(array[i]>0)                  // Проверяем условие - если элемент массива больше 0
//     {
//         sumPositive += array[i];    // Прибавляем к переменной sumPositive этот элемент
//     }
//     else                            // Иеаче
//     {
//         sumNegative += array[i];    // прибавляем этот элемент к переменной sumNegative
//     }
// }
// System.Console.WriteLine($"Сумма положительных чисел: {sumPositive}"); // Выводим результат для положительных элементов
// System.Console.WriteLine($"Сумма отрицательных чисел: {sumNegative}"); // Выводим результат для отрицательных элементов

// Метод (Функция) заполнения массива случайными числами

int[] GenerateArray(int size)
{
    int[] array = new int[size];      // выделяем память под массив из 12 элементов
    Random rand = new Random();     // Создаем класс Random 

    for (int i = 0; i < size; i++)   // Циклом проходим по элементам массива
    {
        array[i] = rand.Next(-9, 10);       // и заполняем его случайными числами из диапазона [-9, 9] - 10 не входит
    }
    return array;
}

// Метод (Функция) вывода массива
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]"); // выводим полученный массив
}

var myArray = GenerateArray(12);
PrintArray(myArray);

int sumPositive = 0;                  // объявляем переменные sum (Для положительных и отрицательных результатов)
int sumNegative = 0;
for (int i=0; i<myArray.Length; i++)  // Проходимся циклом по элементам массива
{
    if(myArray[i]>0)                  // Проверяем условие - если элемент массива больше 0
    {
        sumPositive += myArray[i];    // Прибавляем к переменной sumPositive этот элемент
    }
    else                              // Иеаче
    {
        sumNegative += myArray[i];    // прибавляем этот элемент к переменной sumNegative
    }
}
System.Console.WriteLine($"Сумма положительных чисел: {sumPositive}"); 
System.Console.WriteLine($"Сумма отрицательных чисел: {sumNegative}"); 