// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



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

// вывод в консоль
void PrintNumber(int[,] number)
{
    for (int j = 0; j < number.GetLength(0); j++)
    {
        // Console.Write("|");
        for (int i = 0; i < number.GetLength(1); i++)
        {
            Console.Write($"{number[j, i],3}");
        }
        Console.WriteLine();
    }
}

void FindArrElem(int[,] number)
{
    Console.Write($"Среднее арефметическое каждого столбца: ");
    for (int j = 0; j < number.GetLength(1); j++)
    {
        double sum = 0; ;
        for (int i = 0; i < number.GetLength(0); i++)
        {
            sum += number[i, j];
        }
        double result = sum / number.GetLength(0);
        Console.Write($" {Math.Round(result, 1)}; ");
    }
    
}
int[,] array2d = CreateNumberRndInt(3, 4, 1, 10);
PrintNumber(array2d);
FindArrElem(array2d);
