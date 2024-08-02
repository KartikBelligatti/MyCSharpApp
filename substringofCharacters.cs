class substringofCharacters{
    public void Main(){
        string str =  "abcabcdeef";
        HashSet<char> charSet = LongestSubstring(str);
        string result = string.Concat(charSet); 
        Console.WriteLine(result);
    }

    public static HashSet<char> LongestSubstring(string str){
        HashSet<char> h=new HashSet<char>();

        foreach(char s in str){
            h.Add(s);
        }

        return h;
        
    }
}