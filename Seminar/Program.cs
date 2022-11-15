// Написать прогр, к-ая принимает на вход число и выдает сумму чисел от 1 до этого числа



//  функция
 int GetSummFrom1ToN(int n)
 {
    int result = 0;
    int count = 0;

    while (count < n)
    {
        count ++;
        result += count;
    }

    return result;
 }


 Console.WriteLine("Программа расчета суммы чисел от 1 до N");
 Console.WriteLine("Пожалуйста введите число");

int number = int.Parse(Console.ReadLine()!);

int result = GetSummFrom1ToN(number);
Console.WriteLine("Результат: " + result);
