﻿void Assigment()
{
    {
        int a, b, c;
        a = b = c = 34;
        a += b; // a=a+b
        a -= b; // a=a-b
        a *= b; // a=a*b
        a /= b; //дальше уже и так понятно
        a %= b; 
        a &= b;
        a |= b;
        a ^= b;
        a <<= b;
        a >>= b;
    }
    {
        /* Операции присвоения являются правоассоциативными, то есть выполняются справа налево. */
        int a = 8;
        int b = 6;
        int c = a += b -= 5;    // 9
    }
    
}