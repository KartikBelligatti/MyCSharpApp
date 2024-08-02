class Palindrome{
    public void Main(){
        string str = "osos";
        char[] ch = str.ToCharArray();
        string revstr="";

        for(int i=str.Length-1;i>=0;i--){
            revstr+=ch[i];
        }

        if(revstr == str)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not a Palindrome");
    }
}