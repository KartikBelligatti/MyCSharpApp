class shiftIndex{
    public void Shift(){
        int[] A = new int[] {1,2,3,4,5};
        int n = 2;
        int len = A.Length;

        int[] B = new int[A.Length];

        for(int i=0; i<len-n; i++){
            B[i] = A[i+n];
        }

        for(int i=0; i<n; i++){
            B[n+i+1] = A[i];
        }

        Console.WriteLine("New Array: "+ string.Join(", ", B));
    }
}