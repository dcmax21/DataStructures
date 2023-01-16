﻿
// make a Stac using my own class code
// it must impliment a Push and a pop function
// class must must be initialized from the main function.
using System;
using System.Collections;
using System.Linq;
using System;
using System.Collections.Generic;


    public class UnderFlowException : Exception 
    {
        public UnderFlowException() { }
        public UnderFlowException(string message) 
            : base(message) 
        {
        }

    }

namespace Staks
{   
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
                throw new OverflowException("Stack is full");
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
                throw new UnderFlowException("underflow");
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
}






