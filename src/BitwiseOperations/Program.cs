void LogicalOperations()
{
    /* & */
    {
        int x1 = 2; //010
        int y1 = 5; //101
        Console.WriteLine(x1 & y1); // выведет 0 т.к (0*1=0 | 1*0=0 | 0*1=0) 000=0

        int x2 = 4; //100
        int y2 = 5; //101
        Console.WriteLine(x2 & y2); // выведет 4 т.к (1*1=1 | 0*0=0 | 0*1=0) 100=4
    }
    /* | */
    {

    }
}