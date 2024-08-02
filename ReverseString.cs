class ReverseString{
    public void Main(){
        string str = "kartik";
        char[] ch = str.ToCharArray();
        string revstr = "";

        for(int i=ch.Length-1;i>=0;i--){
            revstr+=ch[i];
        }
        Console.WriteLine(revstr);
    }
}