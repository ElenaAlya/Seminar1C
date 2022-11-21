// напишите программу замена элементов массива: полож элементы замените на соответствующие отрицательные и наоборот

static int[] ArrayReplace(int[] arrayNumbers)
{
  int [] result = new int [arrayNumbers.Length]

  for (int i = 0; i < arrayNumbers.Length; i++)
  {
    result [i] = arrayNumbers [i] * -1;
  }

return result;  
}
 // Задайте массив.Напиши программу которая определяет присутствует ли заданное пользователем число в массиве или нет

 bool CheckArrray (int [] array, int checkNumber)
 {
    bool check = false;

    for (int i = 0; i< array.Length; i++)
    {
       if(array[i] == checkNumber)
       {
       check = true;
       break;
       }
    }
    return check;
 }
     