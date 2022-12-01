// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int M = InputNumbers("Введите M: ");
int N = InputNumbers("Введите N: ");
int temp = M;

if (M > N)
{
    M = N;
    N = temp;
}

PrintSum(M, N, temp = 0);

void PrintSum(int M, int N, int sum)
{
    sum = sum + N;
    if (N <= M)
    {
        Console.Write($"Cумма натуральных элементов в промежутке от M до N = {sum}");
        return;
    }
    PrintSum(M, N - 1, sum);
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
