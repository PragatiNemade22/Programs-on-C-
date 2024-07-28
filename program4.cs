using System;
 class Program4
 {
    //outside main function 
    static float Addition(float fNo1,float fNo2)
    {
        float fAns=0.0f;
        fAns=fNo1+fNo2;
        return fAns;
    }
    static void Main()//int main()
    {
        float fValue1 =0.0f;
        float fValue2 =0.0f;
        float fResult=0.0f;
        
        Console.WriteLine("Enter first number:");
        fValue1=float.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        fValue2 = float.Parse(Console.ReadLine());

        fResult = Addition(fValue1, fValue2);

        Console.WriteLine("Addition is: " + fResult);


        


    }


 }