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
    }
}
