// Задача 52. Задайте двумерный массив и посчитать сумму по главной диагонали


int Diagonale (int[,] input)
{
    var sum = 0;

    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
           if (i==j) sum = sum + input[i, j];
        }
        
    }
    return sum;
}

int[,] CreateArray(int rows, int colomns)   // функция создания двумерного массива должна принимать размерность массива
{

    int[,] array = new int[rows, colomns];
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < colomns; j++)
        {
            array[i, j] = i + j;
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

Console.WriteLine(Diagonale(array));