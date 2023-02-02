// using System;
// using System.Collections;
// using System.Linq;
// using System;
// using System.Collections.Generic;
// using stacks;
// using queues;
    
//     public class UnderFlowException : Exception 
//     {
//         public UnderFlowException() { }
//         public UnderFlowException(string message) 
//             : base(message) 
//         {
//         }

//     }
//     public class OOverFlowException : Exception 
//     {
//         public OOverFlowException() { }
//         public OOverFlowException(string message) 
//             : base(message) 
//         {
//         }

//     }





//     class Program 
// {
//     static void Main(string[] args) 
//     {
      
//         Queuee queue = new Queuee();
//         try 
//         {
//             queue.Enqueue("chuck");
//             queue.Enqueue("cam");
//             queue.Enqueue("mom");
//             queue.Enqueue("dad");
//             queue.Enqueue("sis");
//             queue.Enqueue("cats");
//             queue.Enqueue("sis");
//             queue.Enqueue("cats");
             
//         }
//         catch(OverflowException e)
//         {
//             Console.WriteLine(e.Message);
//             return;
//         }


//         try 
//         {
//             // Console.WriteLine("Dequeue " + queue.Dequeue());
//             // Console.WriteLine("Dequeue " + queue.Dequeue());
//             // Console.WriteLine("Dequeue " + queue.Dequeue());
//             // Console.WriteLine("Dequeue " + queue.Dequeue());
//             // Console.WriteLine("Dequeue " + queue.Dequeue());
//             // Console.WriteLine("Dequeue " + queue.Dequeue());
//             // Console.WriteLine("Dequeue " + queue.Dequeue());
//         }
//         catch(UnderFlowException e)
//         {
//             Console.WriteLine(e.Message);
//         }
       
//         queue.Print();
//         Stack stacks = new Stack();
//             try 
//             {
//                 stacks.Push("camren");
//                 stacks.Push("mom");
//                 stacks.Push("dad");
//                 stacks.Push("sister");
//                 stacks.Push("Cats");
//             }
//             catch(OverflowException e)
//             {
//                 Console.WriteLine(e);
//             }

//             try 
//             {
//                 Console.WriteLine("pop " + stacks.Pop());
//                 Console.WriteLine("pop " + stacks.Pop());
//                 Console.WriteLine("pop " + stacks.Pop());
//                 Console.WriteLine("pop " + stacks.Pop());
//                 Console.WriteLine("pop " + stacks.Pop());
//                 Console.WriteLine("pop " + stacks.Pop());
//             }
//             catch(UndersFlowException e)
//             {
//                 Console.WriteLine(e.Message);
//             }
//             // stacks.Print();
//             // stacks.Puts("hellos there");
//     }
    
// }


