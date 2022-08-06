using System;
class Calculator
{
    static int result(int a,int b,char choise)
    {
        int result=0 ;
        switch (choise)
        {
            case '+':
                result = a + b;
                break;
            case '-':
                result = a - b;
                break;
            case '*':
                result = a * b;
                break;
            case '/':
                result= a / b;
                break;
            default:
                result = 0; ;
                break;
      
        }
        return result;
    }
    static void Main()
    {
        Console.Write("Enter the First no:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second no:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the Operator:");
        char choise = Convert.ToChar(Console.ReadLine());

        Console.WriteLine(result(a, b, choise));
        Console.ReadKey();
    }
}
