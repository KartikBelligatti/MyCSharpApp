public class revSentence {
    public void ReverseWords(string s) {
        string[] strArray = s.Split(' ');
        List<string> lst= new List<string>();
        string[] revArray;
        foreach(string i in strArray){
            lst.Add(i);
        }
        string result = string.Join(", ", lst);
        Console.WriteLine(result);
    }
}