class CharacterFrequency{
    public void Main(){
        string str = "hello world kartik";
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach(char c in str){
            if(charCount.ContainsKey(c)){
                charCount[c]++;
            }
            else{
                charCount[c] = 1;
            }
        }

        Console.WriteLine("Character Frequencies ");
        foreach(var item in charCount){
            if(item.Value > 1){
                Console.WriteLine($"Character '{item.Key}: has repeated '{item.Value}");
            }
        }
    }
}