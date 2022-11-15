// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.WriteLine ("Введите число");
int number = int.Parse (Console.ReadLine()!);

int ProductOfNumbers (int number)
{
    int count = 1;
    int result = 1;
    while (count <= number)
    {
     result = result * count;
     count++;
    }
    return result;
}
int result = ProductOfNumbers (number);
Console.WriteLine ("Результат " + result);
// нет проверки ввода try parse или trim