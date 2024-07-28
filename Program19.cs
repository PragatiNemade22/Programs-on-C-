using System;

class Program
{
    static int CountDigits(int iNo)
    {
        int iDigit = 0, iCount = 0;

        if (iNo < 0)
        {
            iNo = -iNo;
        }

        while (iNo > 0)
        {
            iDigit = iNo % 10;
            iNo =iNo/10;
            iCount++;
        }

        return iCount;
    }

    static void Main()
    {
        int iValue = 0, iRet = 0;

        Console.WriteLine("Enter number:");
        iValue = int.Parse(Console.ReadLine());

        iRet = CountDigits(iValue);

        Console.WriteLine($"Number of digits are: {iRet}");
    }
}
