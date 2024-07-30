void BinaryAO()
{
    /* + */
    {
        int a = 10;
        int b = a + 12; // 22;
    }
    /* - */
    {
        int a = 10;
        int b = a - 6; // 4;
    }
    /* * */
    {
        int a = 10;
        int b = a * 5; // 50;
    }
    /* / */
    {
        int a = 10;
        int b = a / 5; // 2

        double c = 10;
        double d = 3;
        double e = c / d; // 3.33333333
    }
    {
        double a = 10.0 / 4.0; // 2.5
        double b = 10.0;
        double c = b % 4.0; //2
    }
}
void UnaryAO()
{
    /* ++ */
    {
        int x1 = 7;
        int b1 = ++x1; //b1=8 x1=8
        Console.WriteLine($"{x1} - {b1}");
    }
    {
        int x1 = 7;
        int b1 = x1++; // b1=8 x1=7
        Console.WriteLine($"{x1} - {b1}");
    }
    /* -- */
    {
        int x1 = 7;
        int b1 = --x1; //b1=6 x1=6
        Console.WriteLine($"{x1} - {b1}");
    }
    {
        int x1 = 7;
        int b1 = x1--; // b1=6 x1=7
        Console.WriteLine($"{x1} - {b1}");
    }
    /* priority*/
    {
        int a = 3;
        int b = 5;
        int c = 40;
        int d = c-- - b * a;    // d = (c--)-(b*a);

    }
}
