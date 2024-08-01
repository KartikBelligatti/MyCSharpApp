using System;

class FactorialIterative
{
    public void Factorial()
    {
        Console.WriteLine("Enter a non negative integer..");
        int num = int.Parse(Console.ReadLine());
        int fact=1;
        if(num<0){
            Console.WriteLine("Factorial of a number cannot be  negative");
        }
        else{
            for(int i=1;i<=num;i++){
                fact*=i;
            }
        }
        Console.WriteLine("Factorial of {0} is {1}",num, fact);
    }
}