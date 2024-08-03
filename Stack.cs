// class inbuiltStack{
//     public void Main(){
//         Stack<int> stack = new Stack<int>();

//         stack.Push(1);
//         stack.Push(2);
//         stack.Push(3);

//         foreach(int item in stack){
//             Console.WriteLine(item);
//         }
//         Console.WriteLine("Poping stack element: {0}",stack.Pop());
//         Console.WriteLine("Poping stack element: {0}",stack.Pop());

//         Console.WriteLine("Peeking stack top element: {0}",stack.Peek());

//         Console.WriteLine("Checking stack is empty or not");
//         Console.WriteLine(stack.Count==0?"Stack is empty":"Stack is not empty");
//     }

// }

class Stack<T>{
    private T[] elements;
    private int size;
    private int capacity;

    public Stack(int capacity=10){
        this.capacity = capacity;
        elements = new T[capacity];
        size =0;
    }

    public void Push(T item){
        if(size == capacity){
            throw new InvalidOperationException("Stack overflow");
        }
        elements[size++] = item;
        
    }

    public T Pop(){
        if(size == 0){
            throw new InvalidOperationException("Stack underflow");
        }
        return elements[--size];
    }

    public T Peek(){
        if(size == 0){
            throw new InvalidOperationException("Stack underflow");
        }

        return elements[size-1];
    }

    public bool isEmpty(){
        return size == 0;
    }

    public int Count(){
        return size;
    }
}

class manualStack{
    public void Main1(){
        Stack<int> stack1 = new Stack<int>(5);

        stack1.Push(1);
        stack1.Push(2);
        stack1.Push(3);

        Console.WriteLine("Poping stack element: {0}",stack1.Pop()); // Outputs 3
        Console.WriteLine("Peeking stack top element: {0}",stack1.Peek()); // Outputs 2
        Console.WriteLine("Is stack empty: {0}",stack1.isEmpty()); // Outputs False
        Console.WriteLine("Checking the size of the stack: {0}",stack1.Count()); // Outputs 2
    }
}

