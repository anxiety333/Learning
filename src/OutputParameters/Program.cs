void OutputParameters()
{
        {
            void Increment(int n)
        {
            n++;
            Console.WriteLine($"Число в методе Increment: {n}");
        }

        int number = 5;
        Console.WriteLine($"Число до метода Increment: {number}");
        Increment(number);
        Console.WriteLine($"Число после метода Increment: {number}");
    }
    {
        void Increment(ref int n)
        {
            n++;
            Console.WriteLine($"Число в методе Increment: {n}");
        }

        int number = 5;
        Console.WriteLine($"Число до метода Increment: {number}");
        Increment(ref number);
        Console.WriteLine($"Число после метода Increment: {number}");
    }
    {
        void Sum(int x, int y, out int result)
        {
            result = x + y;
        }

        int number;

        Sum(10, 15, out number);

        Console.WriteLine(number);   // 25
    }
    {
        void GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr)
        {
            rectArea = width * height;      
            rectPerimetr = (width + height) * 2; 
        }

        int area;
        int perimetr;

        GetRectangleData(10, 20, out area, out perimetr);

        Console.WriteLine($"Площадь прямоугольника: {area}");      
        Console.WriteLine($"Периметр прямоугольника: {perimetr}");   
    }
    {
        void GetRectangleData(in int width, in int height, out int rectArea, out int rectPerimetr)
        {
            //width = 25; // нельзя изменить, так как width - входной параметр
            rectArea = width * height;
            rectPerimetr = (width + height) * 2;
        }

        int w = 10;
        int h = 20;
        GetRectangleData(w, h, out var area, out var perimetr);

        Console.WriteLine($"Площадь прямоугольника: {area}");     
        Console.WriteLine($"Периметр прямоугольника: {perimetr}"); 
    }
    {
        void Increment(ref readonly int n)
        {
            // n++; // нельзя, иначе будет очишка компиляции
            Console.WriteLine($"Число в методе Increment: {n}");
        }

        int number = 5;
        Increment(ref number);
        Console.WriteLine($"Число после метода Increment: {number}");
    }
}