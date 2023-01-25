using System;
using System.Collections;
using System.Linq;
using System;
using System.Collections.Generic;

namespace queues
{
    class Queuee
    {
        private string[] arr;
        private int tail;
        private int head;
        public Queuee()
        {
            arr = new string[6];
            head = 0;
            tail = 0;
        }
        
        public void Enqueue(string name) 
        {
            
            if (tail >= 5)
            {
                throw new OverflowException("Queue is full");
            }
            // Console.WriteLine(tail);
            arr[tail] = name;
            

            if (tail == arr.Length) 
            {
                tail = 1;
            }
            else 
            {
                arr[tail] = arr[tail++];
                
            }
        
        }
            public bool IsEmpty() 
            {
                if (head == 0) 
                {
                    return true;
                }
                return false;
                
            }
        public void Print() 
        {
            Console.WriteLine($"The first one in the in the queue is {arr[head]}");
            Console.WriteLine($"And the last one in the queue is {arr[tail-1]}");
            // Console.WriteLine(arr[head]);
            // Console.WriteLine(arr[tail-1]);
        }

        public string Dequeue()
        {
            Console.WriteLine($"head:{head}");
            if (IsEmpty())
            {   
                throw new UnderFlowException("underflow");
                
            }
            var x = arr[head];

            if (head == arr.Length) 
            {
                head = 1;
            }
            else
            {
                head++;
                
            }
            
            return x;
        }
    }
}
