class PrimeNumber{
    public void Main(){
        int limit = 20;
        printPrimes(limit);
    }

    public static void printPrimes(int limit){
        for(int i=2; i<=limit; i++){
            if(IsPrime(i)){
                Console.WriteLine(i);
            }
        }
    }
    
    public static bool IsPrime(int num){
        if(num<2){
            return false;
        }
        for(int i=2; i<=Math.Sqrt(num); i++){
            if(num%i==0){
                return false;
            }
        }
        return true;
    }
}