//  Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]
// Найдите сумму отриц и полож элементов массива

 int [] CreateArrayWithRandomNumbers(int numbers = 12, int startInterval = -9, int endInterval = 9) // ф-ция создания массива
 {
 int[] result = new int [numbers]; //задаем количество элементов
 Random random = new Random(); // создать класс рандом 

   for (int i=0; i < numbers; i++)
   {
     result [i] = random.Next(startInterval, endInterval + 1);
   }
   return result;
 }


void PrintArray(int[] input) //ф-ция вывода массива
{
 for (int i=0; i < input.Length; i++)
 {
    Console.Write(input[i]);

    if (i != input.Length-1)
    Console.Write(", ");
 }
    Console.WriteLine();
}

 int SumPositiveNumbers(int[] input)
 {
   int result = 0;

   for (int i=0; i < input.Length; i++)
   {  
    if (input[i] > 0)  
     result += input[i];
   }
   return result;
 }


 int SumNegativeNumbers(int[] input)
 {
   int result = 0;

   for (int i=0; i < input.Length; i++)
   {  
    if (input[i] < 0)  
     result += input[i];
   }
   return result;
 }

 var array = CreateArrayWithRandomNumbers(); // не задаем аргументы, тк они заданы по умолчанию в ф-ции
PrintArray(array);

 var positiveSum = SumPositiveNumbers(array);
 Console.WriteLine("Сумма положительных чисел: " + positiveSum);

 var negativeSum = SumNegativeNumbers(array);
 Console.WriteLine("Сумма положительных чисел: " + negativeSum);