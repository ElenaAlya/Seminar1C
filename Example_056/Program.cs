// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int range = InputNumbers("Введите максимальное значение в диапазоне: от 1 до ");

int[,] array = new int[rows, columns];
CreateArray(array);
PrintArray(array);

int minSumRows = 0;
int sumRows = SumRowsElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumRows = SumRowsElements(array, i);
  if (sumRows > tempSumRows)
  {
    sumRows = tempSumRows;
    minSumRows = i;
  }
}

Console.WriteLine($"\n{minSumRows+1} - строкa с наименьшей суммой элементов;");
Console.WriteLine("cумма элементов в этой строке: " + sumRows);

int SumRowsElements(int[,] array, int i)
{
  int sumRows = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumRows += array[i,j];
  }
  return sumRows;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
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