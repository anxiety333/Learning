void PositiveNumbersArray() /*Найдем количество положительных чисел в массиве:*/
{
    int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
    int result = 0;
    foreach (int number in numbers)
    {
        if (number > 0)
        {
            result++;
        }
    }
    Console.WriteLine(result);
}
void InversionArray() /*Вторая задача - инверсия массива, то есть переворот его в обратном порядке:*/
{
    int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
    int l = numbers.Length;
    int temp;
    int k = l / 2;
    for (int i = 0; i < k; i++)
    {
        temp = numbers[i];
        numbers[i] = numbers[l-i-1];
        numbers[l-i-1] = temp;
    }
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}
void SortArray()
{
    int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };
    int temp;
    for (int i = 0;i<nums.Length; i++)
    {
        for (int j = 0; j < nums.Length; j++) 
        {
            
            if (nums[i] > nums[j])
            {
                temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }
    }
    foreach(int number in nums)
    {
        Console.WriteLine(number);
    }
}
