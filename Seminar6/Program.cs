// Напишите программу, которая перевернет одномерный массив (посл элем на первом месте,..)

internal class Program
{
    private static void Main(string[] args)
    {
        int CreateArray(int lengthArray, int startInterval, int endInterval)   // генерация массива
        {
            int[] array = new int[lengthArray];
            Random random = new Random();

            for (int i = 0; i < lengthArray; i++)
            {
                array[i] = random.Next(startInterval, endInterval + 1);
            }   

            return array;
        }

        void Print(int[] array) // функция вывода массива на консоль 
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);

                if (i != array.Length - 1)
                    Console.WriteLine(", ");
            }

            Console.WriteLine();
        }

        // reverse - функция, которая переворачивает массив

        int[] ReverseArray(int[] input)
        {
            int[] array = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                array[i] = input[input.Length - i - 1];
            }
            return array;
        }

        int[] array = CreateArray(10, 0, 100); //присвоили переменной значения функции
        Print(array); // Выводим массив

        int[] newArray = ReverseArray(array);    // переворачиваем массив
        Print(newArray); // выводим новый массив на экран
    }
}