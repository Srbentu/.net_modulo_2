namespace ConsoleApp2.Models;

public static class IntExtensions
{
    public static bool IsEven(this int num)
    {
        return num % 2 == 0;
    }
}