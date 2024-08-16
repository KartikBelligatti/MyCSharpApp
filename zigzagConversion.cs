public class Zigzag{
    public void Main(){
        string s = "AB";
        int numRows = 1;

        if (numRows == 1 || s.Length <= numRows) 
            Console.WriteLine(s);
        else{
        string[] rows = new string[Math.Min(numRows, s.Length)];
        int currentRow = 0;
        bool goingDown = false;

        foreach(char c in s){
            rows[currentRow] +=c;
            if(currentRow == 0 || currentRow == numRows - 1){
                goingDown = !goingDown; 
            }
            currentRow += goingDown ? 1 : -1;
        }

        string result = "";
        foreach(string row in rows){
            result+=row;
        }
        Console.WriteLine(result);
    }
    }
}