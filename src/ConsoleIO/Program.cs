void ConsoleInput()
{
    {
        string hello = "Привет мир";
        Console.WriteLine(hello);
        Console.WriteLine("Добро пожаловать в C#!");
        Console.WriteLine("Пока мир...");
        Console.WriteLine(24.5);
    }
    {
        string name = "Tom";
        byte age = 34;
        float height = 1.7f;
        Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м");
    }
    {
        string name = "Tom";
        byte age = 34;
        float height = 1.7f;
        Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name, height, age);
    }

}
void ConsoleWrite()
{
    {
        string name = "Tom";
        int age = 34;
        double height = 1.7;
        Console.Write($"Имя: {name}  Возраст: {age}  Рост: {height}м");
    }
}
void ConsoleInp()
{
    {
        Console.Write("Введите свое имя: ");
        string? name = Console.ReadLine();
        Console.WriteLine($"Привет {name}");
    }
    {
        Console.Write("Введите имя: ");
        string? name = Console.ReadLine();

        Console.Write("Введите возраст: ");
        byte age = Convert.ToByte(Console.ReadLine());

        Console.Write("Введите рост: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите размер зарплаты: ");
        decimal salary = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м  Зарплата: {salary}$");
    }
}