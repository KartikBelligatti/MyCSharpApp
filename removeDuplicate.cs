class removeDuplicate{
     public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;

        int j = 1;
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[i - 1]) {
                nums[j] = nums[i];
                j++;
            }
        }

        // Optional: Fill the remaining part of the array with a default value
        for (int k = j; k < nums.Length; k++) {
            nums[k] = 0; // or any other value that signifies empty space, like int.MinValue
        }

        return j;
    }
}

class remDup {
    public void Main() {
        int[] nums = { 1, 1, 2, 2, 3, 4, 4, 5 };
        removeDuplicate s = new removeDuplicate();
        int newLength = s.RemoveDuplicates(nums);

        Console.WriteLine("Array after removing duplicates:");
        for (int i = 0; i < newLength; i++) {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
    }
}