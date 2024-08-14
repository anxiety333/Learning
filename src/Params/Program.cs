void Params()
{
    {
        void Sum(params int[] numbers)
        {
            int result = 0;
            foreach (var number in numbers)
            {
                result += number;
            }
            Console.WriteLine(result);

        }
        int[] nums = { 1, 2, 3, 4, 5 };
        Sum(nums);
        Sum(1, 2, 3, 4);
        Sum(1, 2, 3);
        Sum();
    }
    {
        void Sum (int inValue, params int[] numbers)
        {
            int result = inValue;
            foreach (var n in numbers)
            {
                result = result + n;
            }
            Console.WriteLine(result);
        }
        int[] nums = { 1, 2, 3, 4 };
        Sum(10, nums); 
        Sum(1, 2, 3, 4);
        Sum(1, 2, 3);
        Sum(20);
    }
    /*    
     * Так НЕ работает
       void Sum(params int[] numbers, int initialValue)
    */
    {
        void Sum(int[] numbers, int initialValue)
        {
            int result = initialValue;
            foreach (var n in numbers)
            {
                result += n;
            }
            Console.WriteLine(result);
        }

        int[] nums = { 1, 2, 3, 4, 5 };
        Sum(nums, 10);
    }
}