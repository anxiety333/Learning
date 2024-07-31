﻿void LogicalOperations()
{
    /* & */
    {
        int x1 = 2; //010
        int y1 = 5; //101
        Console.WriteLine(x1 & y1); // выведет 0 т.к (0*1=0 | 1*0=0 | 0*1=0) 000=0

        int x2 = 4; //100
        int y2 = 5; //101
        Console.WriteLine(x2 & y2); // выведет 4 т.к (1*1=1 | 0*0=0 | 0*1=0) 100=4
    }
    /* | */
    {
        int x1 = 2; //010
        int y1 = 5; //101
        Console.WriteLine(x1 | y1); // выведет 7 т.к. (1+0|1+0|0+1) 111=7
        int x2= 4; //100
        int y2 = 5; //101
        Console.WriteLine(x2 | y2); // выведет 5 т.к. (1+1 | 0+0 | 0+1) 101=5
    }
    /* ^ */
    {
        int x = 45; // Значение, которое надо зашифровать - в двоичной форме 101101
        int key = 102; //Пусть это будет ключ - в двоичной форме 1100110

        int encrypt = x ^ key; // Результатом будет число 1001011 или 75
        Console.WriteLine($"Зашифрованное число: {encrypt}");

        int decrypt = encrypt^key; // Результатом будет 101101 или 45
    }
    {
        int a = 5; // 1001
        int b = 9; //0101

        a = a ^ b; //a=1001^0101 = 1100 = 12
        b = a ^ b; // 12^5=1101^1001=1001=9
        a = a ^ b; // 12^9 = 1100^1001=0101=5

        Console.WriteLine($"a: {a}"); // 5
        Console.WriteLine($"b: {b}"); // 9
    }
    /* ~ */
    {
        int x = 12; // 00001100
        Console.WriteLine(~x); // 11110011=-13
    }
}