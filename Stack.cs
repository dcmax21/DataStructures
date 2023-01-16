
// make a Stac using my own class code
// it must impliment a Push and a pop function
// class must must be initialized from the main function.
using System;
using System.Collections;
using System.Linq;
using System;
using System.Collections.Generic;

class Stack
{
    private string[] arr;
    private int top;
    public Stack()
    {
        arr = new string[5];
        top = 0; 
    }
    public void Push(string name)
    {
        if (top >= 5)
        {
            Console.WriteLine("O V E R  F L O W ");
            return;
        }
        arr[top++] = name;  
    }
    public void Print()
    {
        foreach(var name in arr)
        {
            Console.WriteLine(name);
        }
    }
    public string Pop()
    {    
        if (IsEmpty())
        {   
            Console.WriteLine("U N D E R  F L O W ");
            return "E";
        }
        top--;
        var data = arr[top];
        arr = arr.Take(top).ToArray();
        return data;    
    }
    public bool IsEmpty() 
    {
        if (top == 0) 
        {
            return true;
        }
        return false;
        
    }
    public void Puts(string text)
    {
        Console.WriteLine(text);
    }
}


class Program
{
    static void Main(string[] args)
    {
        Stack stacks = new Stack();
        stacks.Push("camren");
        stacks.Push("mom");
        stacks.Push("dad");
        stacks.Push("sister");
        stacks.Push("Cats");
        Console.WriteLine("pop " + stacks.Pop());
        Console.WriteLine("pop " + stacks.Pop());
        Console.WriteLine("pop " + stacks.Pop());
        Console.WriteLine("pop " + stacks.Pop());
        Console.WriteLine("pop " + stacks.Pop());
        Console.WriteLine("pop " + stacks.Pop());
        stacks.Print();
        stacks.Puts("hellos there");
    }
}


