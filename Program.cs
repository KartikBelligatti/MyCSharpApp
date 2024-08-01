// -----------Inheritence-------------------

// class A{
//     public A(){
//         Console.WriteLine("dsd");
//     }
// }

// class B:A{
//     public B(){
//         Console.WriteLine("aaaa");
//     }
// }

// public class Program{
//     static void Main(){
//        A a=new A();
//        A b=new B();
//        B c=new B();
//     //    B d=new A();
//     }
// }




// -----------Encapsulation-------------------
// class Rectangle{
//     private double length;
//     private double width;

//     public double area(double len, double wid){
//         this.length=len;
//         this.width=wid;
//         return length*width; 
//     }

//     public void display(double l, double w){
//         Console.WriteLine("Length: {0}",l);
//         Console.WriteLine("Width: {0}",w);
//         Console.WriteLine("Area of rectangle is {0}",l*w);
//     }
// }

// class Program{
//     static void Main(string[] args){
//         Rectangle r = new Rectangle();
//         Console.WriteLine("Enter length");
//         double l=double.Parse(Console.ReadLine());
//          Console.WriteLine("Enter Width");
//         double w=double.Parse(Console.ReadLine());

//         r.display(l,w);
//     }
// }

// //---------------------Abstraction-------------------
// public abstract class Shape{
//     public abstract double Area();

//     public void display(){
//         Console.WriteLine("This is a shape");
//     }
// }

// public class Circle:Shape{
//     private double radius;

//     public Circle(double r){
//         radius=r;
//     }

//     public override double Area()
//     {
//         return Math.PI*radius*radius;
//         }
// }


// class Program{
//     static void Main(string[] args){
//         Shape s = new Circle(5.0);
//         double a=s.Area();
//         Console.WriteLine("Area {0}", a);
//     }
// }



//----------------------polymorphism------------
//---method overriding----
// using System;

// // Base class (Parent class)
// class Shape
// {
//     public virtual void Draw()
//     {
//         Console.WriteLine("Drawing a shape");
//     }
// }

// // Derived class (Child class) inheriting from Shape
// class Circle : Shape
// {
//     public override void Draw()
//     {
//         Console.WriteLine("Drawing a circle");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Shape shape = new Shape();
//         shape.Draw(); // Output: Drawing a shape

//         Circle circle = new Circle();
//         circle.Draw(); // Output: Drawing a circle

//         // Using base class reference to the derived class object
//         Shape circleShape = new Circle();
//         circleShape.Draw(); // Output: Drawing a circle (dynamic binding)
//     }
// }



//--------method overloading-----
// using System;

// class Calculator
// {
//     // Method to add two integers
//     public int Add(int a, int b)
//     {
//         return a + b;
//     }

//     // Method to add three integers
//     public int Add(int a, int b, int c)
//     {
//         return a + b + c;
//     }

//     // Method to add two doubles
//     public double Add(double a, double b)
//     {
//         return a + b;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Calculator calc = new Calculator();

//         // Calling the Add method with different parameter lists
//         int sum1 = calc.Add(5, 10);
//         int sum2 = calc.Add(5, 10, 15);
//         double sum3 = calc.Add(2.5, 3.5);

//         Console.WriteLine("Sum1: " + sum1); // Output: Sum1: 15
//         Console.WriteLine("Sum2: " + sum2); // Output: Sum2: 30
//         Console.WriteLine("Sum3: " + sum3); // Output: Sum3: 6
//     }
// }



//Array index shifting program

// class Program{
//     public static void Main(string[] args){
//         int[] A=new int[] {1,2,3,4,5};
//         int n=2;
//         int len=A.Length;
//         int[] B=new int[A.Length];
//         for(int i=0;i<len-n;i++){
//             B[i]=A[i+n];
//         }
//         for(int i=0;i<n;i++){
//             B[n+i+1]=A[i];
//         }

//         Console.WriteLine("New array: " + string.Join(", ", newArray));
//     }
// }



// // I/P array:  {1, 9, 3, 10, 4, 20, 2}
// // O/P : 4
// // Explanation: The subsequence 1, 3, 4, 2 is the longest subsequence of consecutive elemen
// using System;
// using System.Collections.Generic;

// class Program{
//     public static void Main(string[] args){
//         int[] a=new int[]{36, 41, 56, 35, 44, 33, 34, 92, 43, 32, 42};
//         int n=a.Length;

//         List<int> lss=Fss(a);
//         Console.WriteLine("Longest Subseq");
//         foreach(int num in lss){
//             Console.Write(num+" ");
//         }
//     }

//     private static List<int> Fss(int[] a)
//     {
//         HashSet<int> numSet= new HashSet<int>(a);
//         List<int> lss=new List<int>();

//         foreach(int num in a){
//             if(!numSet.Contains(num-1))
//             {
//                 List<int> currentSub=new List<int>();
//                 int currentNum=num;

//                 while(numSet.Contains(currentNum)){
//                     currentSub.Add(currentNum);
//                     currentNum++;
//                 }
//                 if(currentSub.Count>lss.Count){
//                     lss=currentSub;
//                 }
//             }
//         }
//         return lss;
//     }
// }




// //Reverse a string
// class Program{
//     public static void Main(string[] args){
//         string str="kartik";
//         char[] ch=str.ToCharArray();
//         string revstr="";
//         for(int i=str.Length-1;i>=0;i--){
//             revstr+=ch[i];
//         }
//         Console.WriteLine(revstr);
//     }
// }


//Palindrome program
// class Program{
//     public static void Main(string[] args){
//         string str="sos";
//         char[] ch=str.ToCharArray();
//         string revstr="";
//         for(int i=str.Length-1;i>=0;i--){
//             revstr+=ch[i];
//         }
//         if(revstr==str)
//             Console.WriteLine("Palindrome");
//         else
//             Console.WriteLine("Not a Palindrome");
//     }
// }

// //sum of array
// class Program{
//     public static void Main(string[] args){
//       int[] a=new int[] {1,2,3,4,5};
//     //   int sum=a.Sum();
//     int sum=0;
//     for(int i=0;i<a.Length;i++)
//         sum+=a[i];
//       Console.WriteLine(sum);
//     }
// }

//Write a function that prints the numbers from 1 to 100. 
//But for multiples of three, print "Fizz" instead of the number and 
//for the multiples of five print "Buzz".
// For numbers which are multiples of both three and five print "FizzBuzz".
// class Program{
//     public static void Main(string[] args){

//         for(int i=1;i<=100;i++){
//             if(i%3==0 && i%5==0)
//                 Console.WriteLine("FizzBuzz");
//             else if(i%3==0)
//                 Console.WriteLine("Fizz");
//             else if(i%5==0)
//                 Console.WriteLine("Buzz");
//             else
//                 Console.WriteLine(i);
//         }
//     }
// }


// Find Prime Numbers


// class Program{
//     public static void Main(String[] args){
//         int limit= 20;
//         printPrimes(limit);
//     }

//     public static void printPrimes(int limit){
//         for(int i=2; i<=limit;i++){
//             if(IsPrime(i))
//                 Console.WriteLine(i);
//         }
//     }

//     public static bool IsPrime(int num){
//         if(num<2)
//             return false;
//         for(int i=2;i<=Math.Sqrt(num);i++){
//             if(num%i==0)
//                 return false;
//         }
//         return true;
//     }
// }




// // //Longest Substring Without Repeating Characters
// using System;
// using System.Collections.Generic;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         string str = "abcabcbdeef";
//         int len = LenofLongestSubstr(str);
//         Console.WriteLine(len);
//     }

//     public static int LenofLongestSubstr(string str)
//     {
//         char[] ch = str.ToCharArray();
//         List<char> ch1 = new List<char>();
//         ch1.Add(ch[0]);
//         int maxLength = 1;

//         for (int i = 1; i < ch.Length; i++)
//         {
//             if (!ch1.Contains(ch[i]))
//             {
//                 ch1.Add(ch[i]);
//                 maxLength++;
//             }
//         }
//         return maxLength;
//     }
// }


// class Program{
//     public static void Main(string[] args){
//         int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
//         int target = 2;
//         int index = BinarySearch(nums, target);
//         Console.WriteLine(index);
//     }

//     public static int BinarySearch(int[] nums, int target){
//         int left=0;
//         int right=nums.Length-1;

//         while(left<=right){
//             int mid=left+(right-left)/2;
//             if(nums[mid]==target)
//                 return mid;
//             if(nums[mid]< target)
//                 left=mid+1;
//             else
//                 right=mid-1;
//         }
//         return -1;
// //     }
// // }


// class Program{
//     public static void Main(string[] args){
//         int[] a={9,6,3,5,2,1};
//         int target=9;
//         int index=BinarySearch(a, target);
//         Console.WriteLine(index);
//     }

//     public static int BinarySearch(int[] a, int target){
//         int left=0;
//         int right=a.Length-1;

//         while(left<=right){
//             int mid=left+(right-left)/2;
//             if(a[mid]==target)
//                 return mid;
//             if(a[mid] < target)
//                 left=mid+1;
//             else
//                 right=mid-1;
//         }
//         return -1;
//     }
// }







// using System;
// using System.Collections.Generic;

// class Program1
// {
//     static void Main()
//     {
//         string input = "hello world kartik";
//         Dictionary<char, int> charCount = new Dictionary<char, int>();

//         foreach (char c in input)
//         {
//             if (charCount.ContainsKey(c))
//             {
//                 charCount[c]++;
//             }
//             else
//             {
//                 charCount[c] = 1;
//             }
//         }

//         Console.WriteLine("Character frequencies:");
//         foreach (var item in charCount)
//         {
//             if (item.Value > 1)
//             {
//                 Console.WriteLine($"Character '{item.Key}': {item.Value} times");
//             }
//         }
//     }
// }
using System.Xml.Serialization;

class Program{
    static void Main(string[] args){

        // //Factorial Iterative method
        // FactorialIterative fi=new FactorialIterative();
        // fi.Factorial();

        // //Factorial Recursive method
        // FactorialRecursive fr=new FactorialRecursive();
        // fr.Fact();

        // //Remove duplicates from array
        // remDup rd=new remDup();
        // rd.Main();

        // //Find the maximum number in the array
        // FindtheMax fm=new FindtheMax();
        // fm.maxNumber();

        // //Array Indexing shifting
        // shiftIndex si=new shiftIndex();
        // si.Shift();

    }
}