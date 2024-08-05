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
        /*Напишите консольную программу, в которую пользователь вводит с клавиатуры число. Если число одновременно больше 5 и меньше 10, 
         * то программа выводит "Число больше 5 и меньше 10". Иначе программа выводит сообщение "Неизвестное число".*/
        void MoreLessNumbers()
        {
            Console.WriteLine($"Введите два числа:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 > 5 && num1 < 10) Console.WriteLine($"Число больше 5 и меньше 10");
            else Console.WriteLine("Неизвестное число");
        }
        /*Напишите консольную программу, в которую пользователь вводит с клавиатуры число. Если число либо равно 5, либо равно 10, 
         * то программа выводит "Число либо равно 5, либо равно 10". Иначе программа выводит сообщение "Неизвестное число".*/
        void MoreLessNumbers2()
        {
            Console.WriteLine($"Введите два числа:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 5 | num1 == 10) Console.WriteLine($"Число либо равно 5, либо равно 10");
            else Console.WriteLine("Неизвестное число");
        }
        /*В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться. 
         * Напишите консольную программу, в которую пользователь вводит сумму вклада. 
         * Если сумма вклада меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200, то начисляется 7%. 
         * Если сумма вклада больше 200, то начисляется 10%. В конце программа должна выводить сумму вклада с начисленными процентами.*/
        void DepositeCalculate()
        {
            Console.WriteLine("Введите сумму вклада");
            double deposite = Convert.ToDouble(Console.ReadLine());
            if (deposite < 100) deposite += deposite / 0.05;
            else if (deposite >= 100 && deposite <= 200) deposite += deposite  * 0.07;
            else deposite += deposite * 0.1;
            Console.WriteLine(deposite);
        }
        /*Изменим предыдущую задачу. Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы. 
         * И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц вне зависимости от их суммы. 
         * Измените программу таким образом, чтобы к финальной сумме дочислялись бонусы.*/
        void BonusDepositeCalculate()
        {
            Console.WriteLine("Введите сумму вклада");
            double deposite = Convert.ToDouble(Console.ReadLine());
            if (deposite < 100) deposite += deposite / 0.05;
            else if (deposite >= 100 && deposite <= 200) deposite += deposite * 0.07;
            else deposite += deposite * 0.1;
            Console.WriteLine(deposite+15);
        }
        /*Напишите консольную программу, которая выводит пользователю сообщение "Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение". 
         * Рядом с названием каждой операции указан ее номер, например, операция вычитания имеет номер 2. 
         * Пусть пользователь вводит в программу номер операции, и в зависимости от номера операции программа выводит ему название операции.
         * Для определения операции по введенному номеру используйте конструкцию switch...case.
         * Если введенное пользователем число не соответствует никакой операции (например, число 120), то выведите пользователю сообщение о том, 
         * что операция неопределена.*/
        void ArithmeticOperations()
        {
            Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1: 
                    Console.WriteLine("Сложение");
                    break;
                case 2:
                    Console.WriteLine("Вычитание");
                    break;
                case 3: 
                    Console.WriteLine("Умножение");
                    break;
                default:
                    Console.WriteLine("Операция неопределена");
                    break;
            }

        }
        /*Измените предыдущую программу. Пусть пользователь кроме номера операции вводит два числа, 
         * и в зависимости от номера операции с введенными числами выполняются определенные действия 
         * (например, при вводе числа 3 числа умножаются). Результа операции выводиться на консоль.*/
        void ArithmeticOperations2()
        {
            Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение , а так же два числа");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    num1 += num2;
                    Console.WriteLine($"Сложение: {num1}");
                    break;
                case 2:
                    num1 -= num2;
                    Console.WriteLine($"Вычитание: {num1}");
                    break;
                case 3:
                    num1 *= num2;
                    Console.WriteLine($"Умножение: {num1}");
                    break;
                default:
                    Console.WriteLine("Операция неопределена");
                    break;
            }

        }
    }
}