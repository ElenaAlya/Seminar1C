// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine()!);
int temp=n;
if ((n<10000)||(n>99999))
{
   Console.WriteLine ("Неверный ввод, запустите программу повторно");
}
else 
{ int rev=0;
    while (n>0)
    {
      int k = n%10;
      rev=rev*10+k;
      n=n/10;
    }
    
        if (temp == rev)
         Console.WriteLine ("это палиндром");
         else
         Console.WriteLine ("это не палиндром");

}

