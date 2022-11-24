// Задайте двумерный маасив, размером mxn, заполненный случайными целыми числами.

int[,] CreateArray(int rows, int colomns)   // функция создания двумерного массива должна принимать размерность массива
{
    var random = new Random();

    int[,] array = new int[rows, colomns];
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < colomns; j++)
        {
            array[i, j] = random.Next(-100, 101);
        }
    }
    return array;
}

void PrintArray(int[,] input)  // функция вывода на вход будет принимать двумерный массив
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