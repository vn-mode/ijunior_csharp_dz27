using System;

namespace vn_mode_csharp_dz27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = { 1, 2, 3, 4, 5, 6, 7 };
            int tempNumber;
            int userNumberPosition = 0;
            int counter = 0;

            Console.Write("Исходный массив чисел: ");

            foreach (int number in arrayNumbers)
            {
                Console.Write(number + " ");
            }

            Console.Write("\nНа какое значение вы хотите сдвинуть массив влево циклически: ");
            userNumberPosition = Convert.ToInt32(Console.ReadLine());

            while (counter < userNumberPosition)
            {
                for (int i = 0; i < arrayNumbers.Length; i++)
                {
                    if ((i + 1) < arrayNumbers.Length)
                    {
                        tempNumber = arrayNumbers[i];
                        arrayNumbers[i] = arrayNumbers[i + 1];
                        arrayNumbers[i + 1] = tempNumber;
                    }
                }
                counter++;
            }
            
            Console.Write("\nИзменённый массив чисел: ");

            foreach (int number in arrayNumbers)
            {
                Console.Write(number + " ");
            }

        }
    }
}
