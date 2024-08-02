using System.Globalization;

class BinarySearch{
    public void Main(){
        int[] num = new int[]{1, 2, 3, 4, 5, 6, 7};
        int target = 8;
        int index = Search(num, target);
        Console.WriteLine(index);
    }

    public static int Search(int[] num, int target){
        int left =0;
        int right = num.Length-1;

        while(left<=right){
            int mid=left+(right-left)/2;
            if(num[mid]==target)
                return num[mid];
            if(num[mid]<target)
                left=mid+1;
            else
                right=mid-1;
        }
        return -1;
    }
}