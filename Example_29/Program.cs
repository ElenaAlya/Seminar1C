// Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.
int [] myArray = new int [8];
void FillArray(int[] collection)
{
  int length = collection.Length;
  int index = 0;
  Random random = new Random();
  while (index<length)
  {
    collection[index] = new Random().Next(0, 2);
    index ++;
  }
}
void PrintArray(int[] col)
{
    Console.WriteLine ("Массив");
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

Console.WriteLine ("Введите число");

int number;
number = 8;
while (!int.TryParse(Console.ReadLine()!, out number) || number<0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ("Неверный ввод");
    Console.ResetColor();
    Console.WriteLine ("Введите число");
}
int[] array = new int [number];
FillArray(array);
PrintArray(array);