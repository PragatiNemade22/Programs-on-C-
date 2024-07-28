// Problem Statement : Accept 2 numbers from user and perform its addition
using System;
class Program3
{
    static void Main()
    {
        int iValue1 =0,ivalue2=0;
        int iResult =0;

        Console.WriteLine("Enter the first number:");
        iValue1 =Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        ivalue2=Convert.ToInt32(Console.ReadLine());
        iResult=ivalue1+iValue2;
        Console.WriteLine("Addition is: " + iResult);
    }
}