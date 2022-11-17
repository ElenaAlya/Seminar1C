// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите количество элементов массива: ");

int elementsCount = int.Parse(Console.ReadLine()!); 
int[] array = new int[elementsCount];

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1,10);
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

int sum = 0;

for (int i = 1; i < array.Length; i+=2)
{
   sum = sum + array[i];
}
 Console.WriteLine("Сумма элементов, стоящих на нечётных позициях =  " + sum);