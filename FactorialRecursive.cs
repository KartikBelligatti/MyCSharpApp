class FactorialRecursive{
    public int CalculateFactorial(int num){
        if(num<0){
            throw new ArgumentOutOfRangeException("Factorial is not defined for negative numbers");
        }
        else if(num==0){
            return 1;
        }
        else{
            return num*CalculateFactorial(num-1);
        }
    }

    public void Fact(){
        Console.WriteLine("Enter a non-negative integer: ");
        int num=int.Parse(Console.ReadLine());

        FactorialRecursive cf=new FactorialRecursive();
        int factorial=cf.CalculateFactorial(num);
        Console.WriteLine("Factorial of {0} is {1}", num, factorial);
    }
}