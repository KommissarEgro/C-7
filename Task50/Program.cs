// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

Console.WriteLine("Введите индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(("Введите индекс столбца: "));
int columns = Convert.ToInt32(Console.ReadLine());


int[,] CreateNumberRndInt(int rows, int columns, int min, int max)
{
    int[,] number = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            number[i, j] = rnd.Next(min, max + 1);
        }
    }
    return number;

}


void PrintNumber(int[,] number)
{
    for (int i = 0; i < number.GetLength(0); i++)
    {
        // Console.Write("|");
        for (int j = 0; j < number.GetLength(1); j++)
        {
            Console.Write($"{number[i, j],3}");
        }
        Console.WriteLine();
    }
}

void CheckNumArr(int[,] number)
{
if (rows > number.GetLength(0) && columns > number.GetLength(1))
    Console.WriteLine("Введите число меньше");
}

void CheckIndArr(int[,] number)
{
    if (rows <= number.GetLength(0) && columns <= number.GetLength(1))
        Console.WriteLine($"Число индекса {number[rows, columns]}");
    else Console.WriteLine($"{rows}, {columns} -> такого числа в массиве нет");
}


int[,] numbers = CreateNumberRndInt(3, 4, 1, 10);
PrintNumber(numbers);
CheckIndArr(numbers);
CheckNumArr(numbers);
