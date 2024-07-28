using System
{
 class Program12
 {
    static void Display(int iNo)
    {
        for(int iCnt =1;iCnt<=iNo/2;iCnt++)
        {
            Console.WriteLine(iCnt);
        }
    }
    static void main()
    {
        int iValue =0;
        Console.WriteLine("Entere the number ");
        iValue=int Parse(Console.ReadLine());
        Display(iValue);
    }
 }
}