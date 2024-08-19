DayTime dayTime = DayTime.Morning;

if (dayTime == DayTime.Morning)
    Console.WriteLine("Доброе утро");
else
    Console.WriteLine("Привет");

enum DayTime
{
    Morning,
    Afternoon,
    Evening,
    Night
}
