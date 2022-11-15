// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// ввод числа

// метод Trim - обрезает пробелы с обоих сторон, убирая ошибки пользователя

// Console.WriteLine ("Введите число");    - моё решение!!!!!!!!!!!!!!!
// int N = int.Parse(Console.ReadLine()!);
// int result = 0;

// while (N>0)
// {
// N /=10;
// result ++;
// }

// Console.WriteLine ("Результат" + result);

Console.WriteLine ("Введите число"); 
  
int NumberOfDigits (int n)
{
    n = Math.Abs(n);  // берет число по модулю
    int result = 0;
    do
    {
        n /=10;
        result ++;
    }
    while (n>0);
    return result;

}

int number = int.Parse(Console.ReadLine()!);

int result = NumberOfDigits(number);
Console.WriteLine("Результат: " + result);