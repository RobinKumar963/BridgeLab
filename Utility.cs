// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DataStructure
{
    /// <summary>
    /// Contain all features of collection to be used in data structure
    /// </summary>
    class Utility
    {
        /// <summary>
        /// Basic Building Block Node
        /// </summary>
        /// <typeparam name="T"></typeparam>
        internal class Node<T>
        {
            internal T data;
            internal Node<T> next;
            public Node(T d)
            {
                data = d;
                next = null;
            }
            public Node()
            {
                data = (T)Convert.ChangeType(0, typeof(T));
                next = null;
            }
        }
        /// <summary>
        /// Link List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        internal class SingleLinkedList<T> where T : IComparable
        {
            internal Node<T> head;


            public SingleLinkedList()
            {
                head = null;
            }
            public SingleLinkedList(T new_data)
            {
                head = new Node<T>(new_data);
            }
            internal Boolean IsEmpty()
            {
                if (head == null)
                    return true;
                else
                    return false;
            }
            internal int Size()
            {
                if (IsEmpty())
                    return 0;
                int size = 0;
                Node<T> temp = this.head;
                while (temp != null)
                {
                    size++;
                    temp = temp.next;

                }
                return size;
            }

            internal void Insert(int pos, T new_data)
            {
                Node<T> new_node = new Node<T>(new_data);
                Node<T> temp = this.head;
                Node<T> prevNode = null;
                if (pos <= this.Size())
                {
                    int count = 0;
                    while (temp != null)
                    {
                        if (pos == count)
                        {
                            new_node = prevNode.next;
                            prevNode.next = new_node;
                            break;
                        }
                        prevNode = temp;
                        temp = temp.next;

                        count++;
                    }
                }
            }


            internal void InsertFront(T new_data)
            {


                Node<T> new_node = new Node<T>(new_data);
                if (IsEmpty())
                {
                    head = new_node;
                    return;
                }

                new_node.next = this.head;
                this.head = new_node;
            }
            internal void InsertFront(Node<T> new_node)
            {
                
                if (IsEmpty())
                {
                    head = new_node;
                    return;
                }

                new_node.next = this.head;
                this.head = new_node;
            }

                
            
           
            internal void InsertLast(T new_data)
            {

                Node<T> new_node = new Node<T>(new_data);
                if (IsEmpty())
                {
                    head = new_node;
                    return;
                }
                Node<T> lastNode = GetLastNode();
                lastNode.next = new_node;
                new_node.next = null;
            }
            internal void InsertLast(Node<T> new_node)
            {

                
                if (IsEmpty())
                {
                    head = new_node;
                    return;
                }
                Node<T> lastNode = GetLastNode();
                lastNode.next = new_node;
                new_node.next = null;
            }


            internal void InsertBefore(T data, T new_data)
            {
                if (IsEmpty())
                    return;
                Node<T> new_node = new Node<T>(new_data);
                Node<T> prevNode = GetPrevNode(data);
                new_node.next = prevNode.next;
                prevNode.next = new_node;
            }
            internal void InsertBefore(Node<T> new_node, T new_data)
            {
                if (IsEmpty())
                    return;
                
                Node<T> prevNode = GetPrevNode(new_node.data);
                new_node.next = prevNode.next;
                prevNode.next = new_node;
            }

            internal void InsertAfter(T data, T new_data)
            {
                if (IsEmpty())
                    return;
                Node<T> new_node = new Node<T>(new_data);
                Node<T> currentNode = GetNode(data);
                new_node.next = currentNode.next;
                currentNode.next = new_node;

            }

            internal void InsertAfter(Node<T> new_node, T new_data)
            {
                if (IsEmpty())
                    return;
                
                Node<T> currentNode = GetNode(new_node.data);
                new_node.next = currentNode.next;
                currentNode.next = new_node;

            }

            internal Node<T> GetNode(T new_data)
            {
                if (IsEmpty())
                    return null;
                Node<T> temp = this.head;
                while (temp != null)
                {
                    if (temp.data.CompareTo(new_data) == 0)
                    {
                        return temp;
                    }
                    temp = temp.next;
                }
                return null;

            }
            internal Node<T> GetNode(int pos)
            {
                if (IsEmpty())
                    return null;
                Node<T> temp = this.head;
                int i = 0;
                while (temp != null)
                {
                    if (i == pos)
                    {
                        return temp;
                    }
                    temp = temp.next;
                    i++;
                }
                return null;
            }

            internal Node<T> GetNextNode(T new_data)
            {
                if (IsEmpty())
                    return null;
                Node<T> temp = this.head;

                while (temp != null)
                {
                    if (temp.data.CompareTo(new_data) == 0)
                    {
                        return temp.next;
                    }

                    temp = temp.next;
                }
                return null;

            }
            internal Node<T> GetPrevNode(T new_data)
            {
                if (IsEmpty())
                    return null;
                Node<T> temp = this.head;
                Node<T> prevNode = null;
                while (temp != null)
                {
                    if (temp.data.CompareTo(new_data) == 0)
                    {
                        return prevNode;
                    }
                    prevNode = temp;
                    temp = temp.next;
                }
                return null;

            }



            internal Node<T> GetLastNode()
            {
                if (IsEmpty())
                    return null;
                Node<T> temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                return temp;
            }
            internal int Index(T new_data)
            {
                int index = 0;
                Node<T> temp = this.head;
                while (temp != null)
                {

                    if (temp.data.CompareTo(new_data) == 0)
                    {
                        return index;
                    }
                    temp = temp.next;
                    index++;
                }

                return -1;
            }
            internal Boolean Search(T new_data)
            {
                Node<T> temp = this.head;
                while (temp != null)
                {
                    if (temp.data.CompareTo(new_data) == 0)
                    {
                        return true;
                    }
                    temp = temp.next;
                }

                return false;
            }
            internal void DeleteFirstNode()
            {

                this.head = this.head.next;


            }
            internal void DeleteLastNode()
            {

                Node<T> lastNodePrevNode = GetPrevNode(GetLastNode().data);
                lastNodePrevNode.next = null;

            }
            internal void DeleteNodeByPos(int pos)
            {

            }

            internal void DeleteNodebyKey(T key)
            {
                Node<T> temp = this.head;
                Node<T> prev = null;
                if (temp != null && temp.data.CompareTo(key) == 0)
                {
                    this.head = temp.next;
                    return;
                }
                while (temp != null && temp.data.CompareTo(key) != 0)
                {
                    prev = temp;
                    temp = temp.next;
                }
                if (temp == null)
                {
                    return;
                }
                prev.next = temp.next;
            }

        }

        /// <summary>
        /// Abstract class list using link list and being implemented by orderd and unordered list  
        /// </summary>
        /// <typeparam name="T"></typeparam>
        internal abstract class List<T> where T : IComparable
        {
            internal SingleLinkedList<T> list;
            
            public List()
            {
                list = new SingleLinkedList<T>();
            }
            public List(T item)
            {
                list = new SingleLinkedList<T>(item);
            }
            /// <summary>
            /// Add is abstract as it is implemented in different way in ordered and unordered.
            /// </summary>
            /// <param name="item">The item.</param>
            internal abstract void Add(T item);
            internal void Remove(T item)
            {
                list.DeleteNodebyKey(item);
            }
            internal Boolean Search(T item)
            {
                return list.Search(item);
            }
            internal Boolean IsEmpty()
            {
                return list.IsEmpty();
            }
            internal int Size()
            {
                return list.Size();
            }
            internal int Index(T item)
            {
                return list.Index(item);
            }
            internal T Pop()
            {
                T item = list.GetLastNode().data;
                list.DeleteLastNode();
                return item;

            }
            internal T Pop(int pos)
            {
                //get item
                T item = list.GetNode(pos).data;
                //delete pos
                list.DeleteNodebyKey(item);
                return item;
            }


        }

        internal class UnOrderedList<T> : List<T> where T :   IComparable 
        {
            public UnOrderedList() : base()
            {


            }
            public UnOrderedList(T item) : base(item)
            {


            }
            /// <summary>
            /// Adds the specified item in unordered way.
            /// </summary>
            /// <param name="item">The item.</param>
            internal override void Add(T item)
            {
                list.InsertLast(item);
            }
            internal void Append(T item)
            {
                list.InsertLast(item);
            }
            internal void insert(int pos, T item)
            {
                list.Insert(pos, item);
            }
        }

        internal class OrderedList<T> : List<T> where T : IComparable
        {
            public OrderedList() : base()
            {


            }
            public OrderedList(T item) : base(item)
            {


            }
            /// <summary>
            /// Add item in Ordered Way.
            /// </summary>
            /// <param name="item">The item.</param>
            internal override void Add(T item)
            {

                Node<T> temp = list.head;
                if (temp == null)
                {
                    list.InsertFront(item);
                    return;
                }


                while (temp != null)
                {
                    if (temp.data.CompareTo(item) == 1)
                    {
                        list.InsertBefore(temp.data, item);
                        return;
                    }
                    temp = temp.next;
                }
                list.InsertAfter(temp.data, item);
            }
        }

        /// <summary>
        /// Stack using link list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        internal class Stack<T> where T : IComparable 
        {
            internal SingleLinkedList<T> stack;

            public Stack()
            {
                stack = new SingleLinkedList<T>();
            }
            internal void push(T item)
            {
                Node<T> top = stack.head;
                if (top == null)
                {
                    stack.InsertFront(item);
                    return;
                }

                stack.InsertBefore(top.data, item);
                stack.head = stack.GetPrevNode(top.data);


            }
            internal T pop()
            {
                Node<T> top = stack.head;
                T item = top.data;
                if (top != null)
                {
                    stack.DeleteFirstNode();
                    return item;
                }
                int value = 0;
                return (T)Convert.ChangeType(value, typeof(T));
            }
            internal T peek()
            {
                Node<T> top = stack.head;
                T item = top.data;
                if (top != null)
                {

                    return item;
                }
                int value = 0;
                return (T)Convert.ChangeType(value, typeof(T));
            }
            internal Boolean IsEmpty()
            {
                return stack.IsEmpty();

            }
            internal int Size()
            {
                return stack.Size();
            }
        }
        /// <summary>
        /// Queue using link list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        internal class Queue<T> where T : IComparable 
        {
            internal SingleLinkedList<T> queue;
            public Queue()
            {
                queue = new SingleLinkedList<T>();
            }
            internal void Enqueue(T item)
            {
                Node<T> rear = queue.GetLastNode();

                
                queue.InsertLast(item);

            }
            internal T Dequeue()
            {
                Node<T> front = queue.head;
                T item = front.data;
                queue.DeleteFirstNode();
                return item;

            }
            internal Boolean IsEmpty()
            {
                return queue.IsEmpty();
            }
            internal int Size()
            {
                return queue.Size();
            }

           
        }
        /// <summary>
        /// Dequeue
        /// </summary>
        /// <typeparam name="T"></typeparam>
        internal class Dequeue<T> where T : IComparable
        {
            SingleLinkedList<T> dequeue;
            public Dequeue()
            {
                dequeue = new SingleLinkedList<T>();
            }

            internal void AddFront(T item)
            {
                dequeue.InsertFront(item);
            }
            internal void AddRear(T item)
            {
                dequeue.InsertLast(item);
            }
            internal T RemoveFront()
            {
                Node<T> front = dequeue.head;
                T item = front.data;
                dequeue.DeleteFirstNode();
                return item;
            }
            internal T RemoveRear()
            {
                Node<T> rear = dequeue.GetLastNode();
                T item = rear.data;
                dequeue.DeleteLastNode();
                return item;

            }
            internal Boolean IsEmpty()
            {
                return dequeue.IsEmpty();
            }
            internal int Size()
            {
                return dequeue.Size();
            }

        }

        /// <summary>
        /// Hash
        /// </summary>
        /// <typeparam name="T"></typeparam>
        internal class Hash <T> where T : IComparable ,IConvertible
        {
            private OrderedList<T>[] hashTableSlot;
            int size;

            

            public Hash()
            {
                hashTableSlot = new OrderedList<T>[10];
                this.size = 10;
            }
            public Hash(int size)
            {
                hashTableSlot = new OrderedList<T>[size];
                this.size = size;
            }
            internal void Add(T key)
            {
                int hashFunctionSize = this.size + 1;
                int slot = Convert.ToInt32(key) % hashFunctionSize;
                hashTableSlot[slot].Add(key); 
            }
            internal Boolean Search(T key)
            {
                int hashFunctionSize = this.size + 1;
                int slot = Convert.ToInt32(key) % hashFunctionSize;
                return hashTableSlot[slot].Search(key);
            }
            internal void Remove(T key)
            {
                int hashFunctionSize = this.size + 1;
                int slot = Convert.ToInt32(key) % hashFunctionSize;
                hashTableSlot[slot].Remove(key);

            }
        }

       
    }

}
