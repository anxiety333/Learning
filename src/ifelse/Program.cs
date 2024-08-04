void iftest()
{
    {
        int num1 = 8;
        int num2 = 6;
        if (num1 > num2)
        {
            Console.WriteLine($"Число {num1} больше числа {num2}");
        }
    }
    {
        int num1 = 8;
        int num2 = 6;
        if (num1 > num2 && num1 == 8) Console.WriteLine($"Число {num1} больше числа {num2}");
    }
}
void elsetest()
{
    {
        int num1 = 8;
        int num2 = 6;
        if (num1 > num2) Console.WriteLine($"Число {num1} больше числа {num2}");
        else Console.WriteLine($"Число {num2} больше числа {num1}");
    }
}
void elseiftest()
{
    {
        int num1 = 8;
        int num2 = 6;
        if (num1 > num2) Console.WriteLine($"Число {num1} больше числа {num2}");
        else if (num1 < num2) Console.WriteLine($"Число {num2} больше числа {num1}");
        else Console.WriteLine($"Число {num1} равно числу {num2}");
    }
}
void TernaryOperation()
{
    int x = 3;
    int y = 2;
    int z = x < y ? (x + y) : (x - y);
    Console.WriteLine(z);
}