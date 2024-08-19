void SwitchCase()
{
    {
        string name = "Bob";

        switch (name)
        {
            case "Bob":
                Console.WriteLine("Ваше имя Bob");
                break;
            case "Tom":
                Console.WriteLine("Ваше имя Tom");
                break;
            case "Sam":
                Console.WriteLine("Ваше имя Sam");
                break;
        }

    }
    {
        string name = "Bob";

        switch (name)
        {
            case "Bob":
                Console.WriteLine("Ваше имя Bob");
                break;
            case "Tom":
                Console.WriteLine("Ваше имя Tom");
                break;
            case "Sam":
                Console.WriteLine("Ваше имя Sam");
                break;
            default:
                Console.WriteLine("А я хз кто ты");
                break;
        }

    }
    {
        int number = 1;

        switch (number)
        {
            case 1:
                Console.WriteLine("case 1");
                goto case 5;
            case 2:
                Console.WriteLine("case 2");
                break;
            case 5:
                Console.WriteLine("case 5");
                break;
            default:
                Console.WriteLine("default");
                break;
        }

    }
    int DoOperation(int op, int a, int b)
    {
        switch (op)
        {
            case 1: return a + b;
            case 2: return a - b;
            case 3: return a * b;
            default: return 0;
        }
    }
    /*Получение результата из switch*/
    int DoOperation1(int op, int a, int b)
    {
        int result = op switch
        {
            1 => a + b,
            2 => a - b,
            3 => a * b,
            _=>0
        };
        return result;
    }
}