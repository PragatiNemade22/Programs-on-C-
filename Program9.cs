using System;

class Program
{
    static void Display(int iNo)
    {
        for (int iCnt = 1; iCnt <= iNo; iCnt++)
        {
            Console.WriteLine("Jay Hanuman...");
        }
    }

    static void Main()
    {
        int iValue = 0;

        Console.Write("Enter number of times you want to display Jay Hanuman on screen: ");
        iValue = int.Parse(Console.ReadLine());

        Display(iValue);
    }
}
