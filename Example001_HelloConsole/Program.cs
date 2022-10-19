Console.WriteLine("2 Hello, World!");



// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Программа вычесления квадрата числа");
Console.WriteLine("Введите число");
// 1. Ввод числа
string inputString = Console.ReadLine()!;
int input = int.Parse(inputString);

// 2. Вычесление квадрата числа
int result = input*input;

// 3. Вывод результата на консоль
Console.Write