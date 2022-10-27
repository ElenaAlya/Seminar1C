// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
 string WriteN = Console.ReadLine()!;
 int N = Convert.ToInt32(WriteN);

 int[]GetCubeTable(int N)
 {
    int[] CubeArray = new int [N];
    
    for (int i = 0, number = 1; i < N; i++, number++)
    {
        CubeArray[i] = number * number * number;
    }
    return CubeArray;
 }

 void PrintTable(int[] Array)
 {
    int number = 1;
    for (int i = 0;i < Array.Length; i++)
    {
        System.Console.Write($"{number} ^ 3 = ");
        System.Console.WriteLine(Array[i]);
        number++;
    }
 }
 int[] CubeTable = GetCubeTable(N);
 Console.WriteLine("Таблица кубов: ");
 PrintTable(CubeTable);
