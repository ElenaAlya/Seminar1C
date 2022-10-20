using System;

namespace homework
{
 
 // Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
 
 class Program
 {

    static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int a;
        a = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine("число чётное");
        }
        else
        {
            Console.WriteLine("число нечётное");
        }
    }
 }   
}
