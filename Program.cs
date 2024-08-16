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

        // // Longest subsequence in the array
        // LongestSubseq lss=new LongestSubseq();
        // lss.Main();

        // // Reverser a string 
        // ReverseString rs= new ReverseString();
        // rs.Main();

        // // Palindrome Program
        // Palindrome p = new Palindrome();
        // p.Main();

        // // Sum of Array
        // sumOfArray sa= new sumOfArray();
        // sa.Main();

        // // Fizz Buzz Program
        // FizzBuzz fb = new FizzBuzz();
        // fb.Main();

        // // Prime Numbers
        // PrimeNumber pn = new PrimeNumber();
        // pn.Main();

        // // Longest Substring Without Repeating Characters
        // substringofCharacters sc = new substringofCharacters();
        // sc.Main();

        // // Binary Search
        // BinarySearch bs = new BinarySearch();
        // bs.Main();

        // // Character frequency program
        // CharacterFrequency cf = new CharacterFrequency();
        // cf.Main();

        // // Stack implementation with inbuilt function 
        // inbuiltStack s = new inbuiltStack();
        // s.Main();

        // // Manual stack implementation
        // manualStack s1 = new manualStack();
        // s1.Main1();

        // // Longest Common prefix program
        // LongestCommonPrefix l = new LongestCommonPrefix();
        // l.Main();

        // // Find the index of the substring in the main string
        // Solution s = new Solution();
        // s.StrStr("butsad", "sad");

        // // Reverse Words in a String
        // ReverseString r = new ReverseString();
        // r.Main();

        // // Zigzag string conversion
        Zigzag z = new Zigzag();
        z.Main();


    }
}


















