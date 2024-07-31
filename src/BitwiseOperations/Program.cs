using System.Runtime.Intrinsics.X86;

void LogicalOperations()
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
    /* negative numbers */
    {
        int x = 12;
        int y = ~x;
        y += 1;
        Console.WriteLine(y); // -12
    }
    /* move */
    {
        int a = 16; // 10000 
        int b = 2;
        int c = a << b; //сдвиг числа 10000 на 2 разряда влево. 1000000 = 64

        Console.WriteLine($"Зашифрованное число: {c}"); //64

        int d = a >> b; //такой же сдвиг. но вправо 100=4

        Console.WriteLine($"Зашифрованное число: {d}");

     }
    {
        int a = 22; // 10110 
        int b = 2;
        int c = a << b; //сдвиг числа 10110 на 2 разряда влево. 1011000 = 88

        Console.WriteLine($"Зашифрованное число: {c}"); //88

        int d = a >> b; //такой же сдвиг. но вправо 101=5

        Console.WriteLine($"Зашифрованное число: {d}");

    }
}

void DataCompression()
{
    int value1 = 1; // 0b0000_0011
    int value2 = 2; // 0b0000_0010
    int value3 = 3; //0b0000_0001
    int result = 0b0000_0000;
    //Сохраняем value1 в result
    result = result | value1;
    //Сдвигаем  разряды result на 2 разряда влево
    result = result << 2;
    //Сохраняем в result значения из value3 
    result = result | value3;

    Console.WriteLine(result); //57
}
