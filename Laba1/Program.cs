using System;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "";
            int n;
            int nmin = 70;

            S = Console.ReadLine();     // Считываем из консоли строку

            n = Mean(S);                // Вызов функции Mean()для подсчета среднего арифмитеческого 

            if (n >= nmin)              // Если значение больше 70 - выводим строку и значение
            {
                Console.WriteLine("Среднее арифмитеческое кодов символов строки:");
                Console.WriteLine(S);
                Console.WriteLine(n);
            }            
        }

        static int Mean(string S)
        {
            int k = 0;               // Сумма кодов символов строки S
            int n = S.Length;       // Длина строки (количество символов)
            
            for (int i=0; i<n; i++) // Проходим по всем символам строки
            {
                k += (int)S[i];     // Суммируем все коды символов                
            }
            
            return (n>0?k/n:0);           // Возврат среднего арифметического значения (Если n <= 0 возврат 0)
        }
    }
}
