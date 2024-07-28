using System;
namespace Program11
{
    static bool CheckDivisible(int iNo)
    {
        if (iNo%4==0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void main()
    {
        int iValue =0;
        bool bRet =false;

        Console.WriteLine("Enter the number to check");
        iVlaue= int Parse(Console.ReadLine());

        if(bRet==true)
        {
            Console.WriteLine("The number is divisible by 4");

        }
        else
        {
            Console.WriteLine("The number is not Divisible by 4");

        }
        bRet=CheckDivisible(iValue);
    }
}