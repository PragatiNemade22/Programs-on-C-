 using System;
 class Program5
 {
    static bool CkeckEvenOdd(unit iNo)//Unsigned int 
    {
        if ((iNo%2)==0)
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
        unit iValue =0;
        bool bRet =false;
        Console.WriteLine("Enter the Number:");
        iValue=unit.Parse(Console.ReadLine());

        bRet =CkeckEvenOdd(iValue);

       if (bRet == true)
        {
            Console.WriteLine($"{iValue} is an Even number");
        }
        else
        {
            Console.WriteLine($"{iValue} is an Odd number");
        }

    }
 }
