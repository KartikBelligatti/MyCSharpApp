class LongestCommonPrefix{
    public string longestPrefix(string[] strs){
        if(strs == null || strs.Length ==0){
            return "";
        }

        string prefix = strs[0];

        for(int i=1; i<strs.Length; i++){
            while(strs[i].IndexOf(prefix) != 0){
                prefix = prefix.Substring(0, prefix.Length - 1);

                if(string.IsNullOrEmpty(prefix))
                    return "";
            }
        }
        return prefix;
    }

    public void Main(){
        string[] strs = { "flower", "flow", "flight"};
        Console.WriteLine(longestPrefix(strs));
    }
}