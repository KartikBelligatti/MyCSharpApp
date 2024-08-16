class ReverseString{
    public void Main(){
        string s = "  hello world  ";
        
        // Split the string into words
        // string[] words = s.Split(' ');
        string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


        // Reverse the array of words
        Array.Reverse(words);

        // Join the words back into a single string with spaces
        string result = string.Join(" ", words);

        Console.WriteLine(result);  
    }
}