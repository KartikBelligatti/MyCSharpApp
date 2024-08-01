using System;

class FindtheMax {
    public  void maxNumber() {
        int[] A = {1, 2, 3, 2, 6, 8};

        int max = 0;
        for (int i = 0; i < A.Length; i++) {
            if (A[i] > max) {
                max = A[i];
            }
        }
        Console.WriteLine("Maximum value is {0}", max);
    }
}