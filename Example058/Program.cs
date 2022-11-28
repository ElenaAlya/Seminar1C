// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

CreateArray(array);
PrintArray(array);

Console.WriteLine();

CreateArray(secondArray);
PrintArray(secondArray);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц:");

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine("Ошибка ввода, нельзя перемножить");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int z = 0; z < array.GetLength(1); z++)
        {
            resultArray[i, j] += array[i, z] * secondArray[z, j];
        }
    }
}

PrintArray(resultArray);

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] input)
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