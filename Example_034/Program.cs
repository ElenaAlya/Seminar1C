// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите количество элементов массива: ");

int elementsCount = int.Parse(Console.ReadLine()!); 
int[] array = new int[elementsCount];

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

FillArray(array);
Console.WriteLine("Вывод массива: ");

void PrintArray(int[] array)
{

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
   
    Console.WriteLine();
}
PrintArray(array);

int count = 0;

for (int i = 0; i < array.Length; i++)
if (array[i] % 2 == 0)
count++;

Console.WriteLine("Количество четных чисел в массиве: " + count);