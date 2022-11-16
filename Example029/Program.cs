// Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

Console.WriteLine("Программа по выводу массива из 8 целых чисел в строку");

int[] MyArray()
{
int[] array = new int[8];
  for (int i = 0; i < array.Length; i++)
  {
   Console.Write("Введите элемент массива под индексом " + i + ": ");
   array[i] = int.Parse(Console.ReadLine()!);
  }
  return array;
}

void PrintArray(int[] array)
{
Console.Write ("Массив: ");
  for (int i = 0; i < array.Length; i++)
  {
     Console.Write(array[i] + " ");
  }
}

int[] array = MyArray();
PrintArray(array);