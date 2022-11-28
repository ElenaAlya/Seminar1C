// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int[,,] array3D = new int[2, 2, 2];

void PrintIndex(int[,,] print)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                Console.Write($"{array3D[i, j, z]}({i},{j},{z}) ");
            }
        }
    }
}

void FillArray(int[,,] print)
{
    int count = 10;
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
            for (int z = 0; z < print.GetLength(2); z++)
            {
                print[z, i, j] += count;
                count += 3;
            }
        }
    }
}

FillArray(array3D);
Console.WriteLine("Вывод трёхмерного массива:");
PrintIndex(array3D);