void BasedConversion()
{
    byte a = 4;
    /* byte b = 50 + a; Ошибка т.к. поменялся тип данных на int*/
    byte b = (byte)(a + 70); // правильно

}
void NarrowingAndExpandingTransformations()
{
    {
        byte a = 4;             // 0000100
        ushort b = a;   // 000000000000100
    }
    {
        ushort a = 4;
        byte b = (byte) a; //значение сужается с 16 бит (2 байт) до 8 бит (1 байт).
    }
}
void ImplicitConversions()
{
    {  /* zero extension */
        byte a = 4;             // 0000100
        ushort b = a;   // 000000000000100
    }
    {
        /* Преобразование отрицательного числа */
        sbyte a = -4;           // 1111100
        short b = a;    // 111111111111100
    }
}
void ExplicitConversions()
{
    {
        int a = 4;
        int b = 6;
        byte c = (byte)(a + b);
    }
    {
        double a = 4.0;
        decimal b = (decimal)a;
    }
}