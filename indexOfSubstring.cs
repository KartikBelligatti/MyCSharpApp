public class Solution {
    public void StrStr(string haystack, string needle) {
        

        int index = haystack.IndexOf(needle);

        if (index != -1)
        {
            Console.WriteLine($"The substring starts at index {index}.");
        }
        else
        {
            Console.WriteLine("The substring was not found.");
        }
    }
}