// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateArray(int rows, int colomns)
{
    var random = new Random();

    double[,] array = new double[rows, colomns];
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < colomns; j++)
        {
            array[i, j] = Math.Round(random.NextDouble()*20-10, 2);
        }
    }
    return array;
}

void PrintArray(double[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write(input[i, j]);

            if (j != input.GetLength(1) - 1)
                Console.Write(", ");
        }
        Console.WriteLine();
    }
}

var array = CreateArray(3,4);
PrintArray(array);