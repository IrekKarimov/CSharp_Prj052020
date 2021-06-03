using System;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            // Ввод данных с консоли.
            Console.Write("Введите число A: ");
            A = Int32.Parse( Console.ReadLine() );
            Console.Write("Введите число B: ");
            B = Int32.Parse( Console.ReadLine() );
            Console.Write("Введите число C: ");
            C = Int32.Parse( Console.ReadLine() );

            // Вывод исходных данных
            Console.WriteLine("Исходные данные:");
            Console.WriteLine(A + ", " + B + ", " + C);

            ShiftRight3(ref A, ref B, ref C);           // Вызов функции ShiftRight3. Переменные передаем по ссылке

            // Вывод результата
            Console.WriteLine("Сдвинутые данные:");
            Console.WriteLine(A + ", " + B + ", " + C);
        }

        static void ShiftRight3(ref int A, ref int B, ref int C)        
        {
            int s;
            s = C;
            C = B;
            B = A;
            A = s;
        }
    }
}
