class LongestSubseq{

    public void Main(){
        int[] a=new int[]{36, 41, 56, 35, 44, 33, 34, 92, 43, 32, 42};

        List<int> lss=FindTheSubseq(a);
        foreach(int num in lss){
            Console.Write(num+" ");
        }
    }
    public static List<int> FindTheSubseq(int[] a){
        HashSet<int> numSet=new HashSet<int>(a);
        List<int> lss=new List<int>();

        foreach(int num in a){
            if(!numSet.Contains(num-1)){
                List<int> CurrentSub = new List<int>();
                int CurrentNum = num;

                while(numSet.Contains(CurrentNum)){
                    CurrentSub.Add(CurrentNum);
                    CurrentNum++;
                }

                if(CurrentSub.Count>lss.Count){
                    lss=CurrentSub;
                }
            }
        }
        return lss;
    }
}