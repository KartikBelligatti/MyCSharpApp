class sumOfArray{
    public void Main(){
        int[] a= new int[] {1,2,3,4,5};
        int sum=0;
        foreach(int i in a){
            sum+=i;
        }
        Console.WriteLine("Sum of array elements is {0}",sum);
    }
}