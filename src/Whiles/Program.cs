using System.Runtime.ExceptionServices;

void Whiles()
{
    {
        for (int i = 1; i < 4; i++)
        {
            Console.WriteLine(i);
        }
    }
    { for (int i = 1; i < 4; i++) Console.WriteLine(i); }
    {
        int i = 1;

        for (Console.WriteLine("Начало выполнения итерации"); i < 4; Console.WriteLine($"i = {i}"))
        {
            i++;
        }
    }
    {
        int i = 1;
        for (; i<4 ; )
        {
            Console.WriteLine($"i={i}");
            i++;
        }
    }
    {
        for (int i = 1, j = 2; i < 10; i++, j++)
        {
            Console.WriteLine($"{i*j} \t");
        }
        Console.WriteLine();
    }
}
void DoWhiles()
{
    {
        int i = 6;
        do
        {
            Console.WriteLine(i);
            i--;
        }
        while (i > 0);
    }
    {
        int i = 6;
        while (i > 0)
        {
            Console.WriteLine(i);
            i--;
        }
    }
    {
        foreach (char c in "TOM")
        {
            Console.WriteLine(c);
        }
    }
    {
        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                Console.Write($"{i * j} \t");
            }
            Console.WriteLine();
        }
    }
}