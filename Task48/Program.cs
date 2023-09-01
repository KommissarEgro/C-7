// Задача 48:Задайте двумернный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m + n.
// Выведете полученный масив на экран.

// m = 3, n = 4.

// 0123
// 1234
// 2345

int[,] CreateMatrixSumInd(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;

}

// вывод в консоль
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 1}");
        }
        Console.WriteLine();
    }
}

int[,] arrary2d = CreateMatrixSumInd(3, 4);
PrintMatrix(arrary2d);