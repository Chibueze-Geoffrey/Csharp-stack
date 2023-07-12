using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkdList
{
    public class Node
    {
        public int data;
        public Node next;

        public Node (int i)
        {
            data = i;
            next  = null;
        }
        public void Print()
        {
              Console.Write("|" + data + "|->");   
              if(next !=null)
              {
                next.Print();
              }
        }
        public void Remove( int data)
        {
            if(next==null)
            {
                next = new Node(data);
            }
            else if (data < next.data)
            {
              Node temp = new Node(data);
              temp.next=this.next;
              this.next = temp; 
            }
             else
             {
                next.Remove(data);
             }
        }
         public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }       
    }
    
    public class MyList
    {
        public Node headNode;
        public MyList() 
        {
            headNode = null;
        }
        public void AddToEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
        }
        public void Remove(int data)
        {
          if (headNode==null)
          {
            headNode= new Node(data);
          }
          else if(data < headNode.data)
          {
            AddToBegining(data);
          }
          else
          {
            headNode.Remove(data);
          }
        }
        public void AddToBegining(int data)
        {
            if(headNode== null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next= headNode;
                headNode = temp;
            }
        }
        public void Print()
        {
            if (headNode !=null)
            {
                headNode.Print();
            }
        }
    }

        // class Program
        // {
        //     static void Main (string [] args)
        //     {
        //     // MyList list = new MyList();
        //     //    list.AddToEnd(52);
        //     //         list.AddToEnd(31); 
        //     //      list.AddToEnd(24);
        //     //      list.AddToBegining(52);
        //     //     list.AddToBegining(31); 
        //     //     list.AddToBegining(24);
        //     //          list.Remove(52);
        //     //          list.Remove(31); 
        //     //         list.Remove(24);
        //     //          list.Print();
        //     }
       // }
    
}