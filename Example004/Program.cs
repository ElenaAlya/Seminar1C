Console.WriteLine("программа вычисления min и max числа");
Console.WriteLine("Введите 3 числа");

int input1 = int.Parse(Console.ReadLine()!);
int input2 = int.Parse(Console.ReadLine()!);
int input3 = int.Parse(Console.ReadLine()!);
int max = input1;
   if (input2 > max) max=input2;
   if (input3 > max) max=input3;

       Console.WriteLine("максимальное число-" + max); 
 