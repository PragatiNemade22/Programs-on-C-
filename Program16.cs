using System;

class Program
{
    static bool CheckPerfect(int iNo)
    {
        int iSum = 0;

        for (int iCnt = 1; iCnt <= (iNo / 2); iCnt++)
        {
            if (iNo % iCnt == 0)
            {
                iSum += iCnt;
            }
        }

        return iSum == iNo;
    }

    static void Main()
    {
        int iValue = 0;
        bool bRet = false;

        Console.WriteLine("Enter number:");
        iValue = int.Parse(Console.ReadLine());

        bRet = CheckPerfect(iValue);
        if (bRet)
        {
            Console.WriteLine("is a perferct no");
        }
        else
        {
            Console.WriteLine(" is not a perfect number");
        }
    }
}
