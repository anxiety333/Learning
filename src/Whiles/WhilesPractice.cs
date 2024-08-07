using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiles
{
    internal class WhilesPractice
    {
        /*За каждый месяц банк начисляет к сумме вклада 7% от суммы. Напишите консольную программу, 
         * в которую пользователь вводит сумму вклада и количество месяцев. А банк вычисляет конечную сумму вклада с учетом начисления 
         * процентов за каждый месяц.Для вычисления суммы с учетом процентов используйте цикл for. 
         * Для ввода суммы вклада используйте выражение Convert.ToDecimal(Console.ReadLine()) (сумма вклада будет представлять тип decimal).*/

        void DepositCalculate()
        {
            Console.WriteLine("Введите сумму вклада и количество месяцев");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            int mounth = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < mounth; i++)
            {
                sum += sum * 0.07M;
                Console.WriteLine(sum);
            }
        }
        /*Перепишите предыдущую программу, только вместо цикла for используйте цикл while.*/
        void DepositCalculateWhile()
        {
            int i = 1;
            Console.WriteLine("Введите сумму вклада и количество месяцев");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            int mounth = Convert.ToInt32(Console.ReadLine());
            while (i<mounth)
            {
                sum += sum * 0.07M;
                Console.WriteLine(sum);
                i++;
            }
        }
        /*Напишите программу, которая выводит на консоль таблицу умножения*/
        void MultiplicationTable()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine(i * j);
                }
                Console.WriteLine();
            }
        }
        /*Напишите программу, в которую пользователь вводит два числа и выводит результат их умножения. 
         * При этом программа должны запрашивать у пользователя ввод чисел, пока оба вводимых числа не окажутся в диапазоне от 0 до 10. 
         * Если введенные числа окажутся больше 10 или меньше 0, то программа должна вывести пользователю о том, что введенные числа недопустимы, 
         * и повторно запросить у пользователя ввод двух чисел. Если введенные числа принадлежат диапазону от 0 до 10, то программа выводит результат 
         * умножения.Для организации ввода чисел используйте бесконечный цикл while и оператор break.*/
        void Calculator()
        {
            int num1 = -1;
            int num2 = -1;
            Console.WriteLine("Введите два числа в диапазоне от 0 до 10");
            while (true)
            {
                num1 = Convert.ToInt32(Console.ReadLine());
                if (num1 < 0 && num1 > 10) Console.WriteLine("Данное число недопустимо. Попробуйте еще раз");
                else break;
            }
            while (true)
            {
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 < 0 && num2 > 10) Console.WriteLine("Данное число недопустимо. Попробуйте еще раз");
                else break;
            }
            Console.WriteLine($"Результат умножения: {num1 * num2}");
        }
    }
}
