using System;

class Program20
{
    static int CountEvenDigits(int iNo)
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
            if(iDigit %2 == 0)
            {
                iCount++;
            }
          
        }

        return iCount;
    }

    static void Main()
    {
        int iValue = 0, iRet = 0;

        Console.WriteLine("Enter number:");
        iValue = int.Parse(Console.ReadLine());

        iRet = CountEvenDigits(iValue);

        Console.WriteLine($"Number of Even digits are: {iRet}");
    }
}
