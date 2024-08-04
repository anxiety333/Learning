using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    internal class ifelsepractice
    {
        
        /* Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа. А программа
         * сранивает два введенных числа и выводит на консоль результат сравнения 
         * (два числа равны, первое число больше второго или первое число меньше второго).*/
        void CompareNumbers()
        {
            Console.WriteLine("Введите два числа:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2) Console.WriteLine($"Число {num1} больше числа {num2}");
            else if (num1 < num2) Console.WriteLine($"Число {num1} меньше числа {num2}");
            else Console.WriteLine($"Числа {num1} и {num2} равны");    
        }

        void MoreLessNumbers()
        {
            Console.WriteLine($"Введите два числа:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 > 5 && num1 < 10) Console.WriteLine($"Число больше 5 и меньше 10");
            else Console.WriteLine("Неизвестное число");
        }
    }
}