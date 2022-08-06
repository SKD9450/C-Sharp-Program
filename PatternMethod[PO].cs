using System;
class Pattern
{
    static void cas(int num)
    {
        int i = 1;
       
       while(i <= num)
       {
            int j = 1;
            while (j<=i)
            {
                j++;
                Console.Write("*");

            }
            i++;
            Console.WriteLine();
       }
    }
    static void Main()
    {
        Console.Write("Enter the no:");
        int num = Convert.ToInt32(Console.ReadLine());

        cas(num);
        Console.ReadKey();
    }
}
