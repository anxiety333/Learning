void Arrays()
{
    {
        int[] numbers;


        int[] nums = new int[4];


        int[] nums2 = new int[4] { 1, 2, 3, 5 };

        int[] nums3 = new int[] { 1, 2, 3, 5 };

        int[] nums4 = new[] { 1, 2, 3, 5 };

        int[] nums5 = { 1, 2, 3, 5 };

        string[] people = { "Tom", "Bob", "Sam" };

        int[] nums6 = [ 1, 2, 3, 5 ];

        int[] nums7 = []; //пустой массив
    }
}
void ArraysIndex()
{
    {
        int[] numbers = { 1, 2, 3, 5 };

        //Получение элемента массива
        Console.WriteLine(numbers[3]); //5

        //Получение элемента массива в переменную
        int n = numbers[2];
        Console.WriteLine(n); //3

        //Изменение элемента массива
        numbers[1] = 123; // [ 1, 123, 3, 5 ]

        //Длина массива
        Console.WriteLine(numbers.Length); //4

        //Получение элементов массива с конца
        Console.WriteLine(numbers[numbers.Length - 1]);  // 5 - первый с конца или последний элемент
        Console.WriteLine(numbers[numbers.Length - 2]);  // 3 - второй с конца или предпоследний элемент
        Console.WriteLine(numbers[numbers.Length - 3]);  // 2 - третий элемент с конца

        //Или 
        Console.WriteLine(numbers[^1]);  // 5 - первый с конца или последний элемент
        Console.WriteLine(numbers[^2]);  // 3 - второй с конца или предпоследний элемент
        Console.WriteLine(numbers[^3]);  // 2 - третий элемент с конца
    }
}
void IteratingArrays()
{
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int i in numbers)
        {
            Console.WriteLine(i); //Вывод каждого элемента массива
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]); 
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            {
                numbers[i] = numbers[i] + 1;
                Console.WriteLine(numbers[i]);
            }
        }

    }
}
void MultidimensionalArrays()
{
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };

        int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };

        int rows = nums2.GetUpperBound(0) + 1; // кол-во строк
        int colums = nums2.Length / rows; // кол-во столбцов
        //или так 
        colums = nums2.GetUpperBound(1) + 1;

    }
}
void BigBossArray()
{
    {
        int[][] nums = new int[3][];

        nums[0] = new int[2] { 1, 5 };
        nums[1] = new int[3] { 2, 3, 6 };
        nums[2] = new int[4] { 3, 4, 5, 8 };
    }
    // Или

    {
        int[][] nums = 
            {
            new int[2]{ 3, 4 },
            new int[3]{ 1, 2, 3 },
            new int[2]{ 5, 4 }
            };
        foreach (int[] row in nums)
        {
            foreach (int number in row)
            {
                Console.WriteLine($"{number} \t");
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums[i].Length; j++)
            {
                Console.Write($"{nums[i][j]} \t");
            }
            Console.WriteLine();
        }
    }
}