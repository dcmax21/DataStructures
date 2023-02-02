using System;
using System.Collections;
using System.Linq;
using System;
using System.Collections.Generic;
class Node
{
   public int data;
   public Node? next;
    public Node(int d) 
    {
        data = d;
        next = null;
    } 
}

class LinkedLists
{
    private Node? head;
    public LinkedLists()
    {  
        head = null;
    }
    public void next(string item)
    {
    
    }
    public void add(int data)
    {
        Node node = new Node(data);
        if (head is null) 
        {
            head = node;
            return;
        }
        var num = head;
        while (num.next != null) 
        {
            num = num.next;
        }
        num.next = node;
    }
    public void search()
    {
            
    }
    public void print() 
    {
        if (head is null) 
        {
            Console.WriteLine("empty");
            return;       
        } 
        while (head.next != null) 
        {
            head = head.next;
            Console.WriteLine(head.data);
        }
    }
}
class Nodesss 
{
    static void Main(string[] args) 
    {
        LinkedLists linkedlists = new LinkedLists();
        linkedlists.add(1);
        linkedlists.add(3);
        linkedlists.add(5);
        linkedlists.add(8);
        linkedlists.add(3);
        linkedlists.print();
    }
}




