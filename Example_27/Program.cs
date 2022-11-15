// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write ("Введите число ");
        int number = Convert.ToInt32(Console.ReadLine()!);
        int SumOfDigits (int number)
        {
            number = Math.Abs(number); 
            int count = Convert.ToString(number).Length;
            int a = 0;
            int result = 0;
            for (int i = 0; i < count; i++)
          {
                a = number - number % 10;
                result = result + (number - a);
                number = number / 10;
          } 
            return result;
        }
        int result = SumOfDigits (number);
        Console.WriteLine("Сумма цифр в числе: " + result);