using System;

namespace Bridgelabz.DataStructure
{
    class MyUtility
    {


        public class Node<T>
        {
            public T data;
            public Node<T> next;
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


        public  interface LinkList<T> where T : IComparable , IConvertible
        {

            

            public Boolean IsEmpty();
            public  void InsertFront(T new_data);
            public  void InsertEnd(T new_data);
            public  void InsertBefore(T beforeData,T new_data);
            public  void InsertAfter(T afterData,T new_data);
            public  Boolean Search(T key);
            public int Size();
            public  Node<T> GetNode(T checkData);
            public  Node<T> GetFirstNode();
            public  Node<T> GetLastNode();
            public  Node<T> GetPreviousNode(Node<T> node);
            public  Node<T> GetNextNode(Node<T> node);
            public void SetHead(Node<T> head);
            public Node<T> GetHead();
            public  void Remove();
            public  void Remove(Node<T> node);
            public  void Remove(T data);
            public  void RemoveFirst();
            public  void RemoveLast();
          


        }

        public class SingleLinkedList<T> : LinkList<T> where T : IComparable, IConvertible
        {
            public Node<T> head;


            public SingleLinkedList(T data)
            {
                head = new Node<T>(data);
            }
            public SingleLinkedList()
            {
                head = null;
            }

            public Node<T> GetFirstNode()
            {
                return head;
                
            }

            public Node<T> GetLastNode()
            {
                if (IsEmpty())
                    return null;

                Node<T> temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                return temp;
            }

            public Node<T> GetNextNode(Node<T> node)
            {
                if (IsEmpty())
                    return null;
                return GetNode(node.data).next;
            }

            public Node<T> GetNode(T checkData)
            {
                if (IsEmpty())
                    return null;
                Node<T> temp = head;
                while (temp != null)
                {
                    if(temp.data.CompareTo(checkData) == 0)
                    {
                        return temp;
                    }
                    temp = temp.next;
                }
                return temp;
            }

            public Node<T> GetPreviousNode(Node<T> node)
            {
                if (IsEmpty())
                    return null;
                
                Node<T> temp = this.head;
                Node<T> prevNode = null;
                while (temp != null)
                {
                    if (temp.data.CompareTo(node.data) == 0)
                    {
                        return prevNode;
                    }
                    prevNode = temp;
                    temp = temp.next;
                }
                return null;
            }
            public void SetHead(Node<T> head)
            {
                this.head = head;
            }
            public Node<T> GetHead()
            {
                return this.head;
            }


            public void InsertAfter(T after_Data , T new_data)
            {
                Node<T> insertAfterNode = GetNode(after_Data);
                Node<T> new_Node = new Node<T>(new_data);
                new_Node.next = insertAfterNode.next;
                insertAfterNode.next = new_Node;

            }

            public void InsertBefore(T before_Data,T new_data)
            {
                Node<T> insertBeforeNode = GetNode(before_Data);
                Node<T> new_Node = new Node<T>(new_data);
                Node<T> prev_Node = GetPreviousNode(insertBeforeNode);
                new_Node.next = insertBeforeNode;
                prev_Node.next = new_Node;
            }

            public void InsertEnd(T new_data)
            {
                Node<T> end_Node = GetLastNode();
                Node<T> new_Node = new Node<T>(new_data);
                end_Node.next = new_Node;
                new_Node.next = null;
            }

            public void InsertFront(T new_data)
            {
                Node<T> new_Node = new Node<T>(new_data);
                new_Node.next = head;
                head = new_Node;

            }

            public bool IsEmpty()
            {
                return head == null;
            }
            public int Size()
            {
                if (IsEmpty())
                    return 0;
                Node<T> temp = head;
                int size = 0;
                while(temp != null)
                {
                    size++;
                    temp = temp.next;
                }
                return size;
            }
            public void Remove()
            {
                
            }

            public void Remove(Node<T> node)
            {
                Node<T> deleteNode = GetNode(node.data);
                GetPreviousNode(deleteNode).next = deleteNode.next;
            }

            public void Remove(T data)
            {
                Node<T> deleteNode = GetNode(data);
                GetPreviousNode(deleteNode).next = deleteNode.next;
            }
            
            public void RemoveFirst()
            {
                ////check here to empty memory properly
                Node<T> temp = GetFirstNode();
                head = temp.next;
                ////Can you free temp here
            }
           
            public void RemoveLast()
            {
                if (head.next == null)
                    head = null;
                else
                    GetPreviousNode(GetLastNode()).next = null;
            }

            public bool Search(T key)
            { 
                Node<T> temp = head;
                while ( temp != null )
                {
                    if (key.CompareTo(temp.data) == 0)
                        return true;
                    temp = temp.next;
                }
                return false;
            }
        }

        public abstract class List<T> where T : IComparable, IConvertible
        {
            public LinkList<T> list;
            public Node<T> head;
            public List()
            {
                list = new SingleLinkedList<T>();
                this.head = null;
            }
            public List(T item)
            {
                list = new SingleLinkedList<T>(item);
                this.head = new Node<T>(item);
            }


            /// <summary>
            /// Add is abstract as it is implemented in different way in ordered and unordered.
            /// </summary>
            /// <param name="item">The item.</param>
            public abstract void Add(T item);

            public void Remove(T item)
            {
                list.SetHead(this.head);
                list.Remove(item);
                this.head = list.GetHead();
                
            }
            public Boolean Search(T item)
            {
                list.SetHead(this.head);
                return list.Search(item);
            }
            public Boolean IsEmpty()
            {
                return head == null;
            }
            public int Size()
            {
                int size = 0;
                Node<T> temp = head;
                while(temp != null)
                {
                    size++;
                    temp = temp.next;
                }
                return size;
            }


            public int Index(T item)
            {
                Node<T> temp = head;
                int index = 0;
                while(temp != null)
                {
                    if (temp.data.CompareTo(item) == 0)
                        return index;
                    index++;
                    temp = temp.next;
                }
                return -1;
            }
            public T Pop()
            {
                list.SetHead(this.head);
                T item = list.GetLastNode().data;
                list.RemoveLast();
                this.head = list.GetHead();
                return item;
            }
            public T Pop(int pos)
            {
                int count = 0;
                Node<T> temp = head;
                while(temp!=null)
                {
                    if (pos == count)
                        break;
                    count++;
                    temp = temp.next;
                }
                return temp.data;
                    
            }


        }

        public class UnOrderedList<T> : List<T> where T : IComparable, IConvertible
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
            public override void Add(T item)
            {
                list.SetHead(this.head);
                list.InsertEnd(item);
                this.head = list.GetHead();
            }
            public void Append(T item)
            {
                list.SetHead(this.head);
                list.InsertEnd(item);
                this.head = list.GetHead();
            }
            internal void Insert(int pos, T item)
            {
                list.SetHead(this.head);
                Node<T> temp = head;
                int count = 0;
                while(temp!=null)
                {
                    if(pos==count)
                    {
                        list.InsertBefore(temp.data,item);
                        this.head = list.GetHead();
                        break;
                    }
                    count++;
                    temp = temp.next;
                }
            }
        }

        public class OrderedList<T> : List<T> where T : IComparable, IConvertible
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
            public override void Add(T item)
            {

                list.SetHead(this.head);
                Node<T> temp = head;
                if (temp == null)
                {
                    list.InsertFront(item);
                    this.head = list.GetHead();
                    return;
                }


                while (temp != null)
                {
                    if (temp.data.CompareTo(item) == 1)
                    {
                        list.InsertBefore(temp.data, item);
                        this.head = list.GetHead();
                        return;
                    }
                    temp = temp.next;
                }
               
            }
        }


        /// <summary>
        /// Stack using link list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class Stack<T> where T : IComparable, IConvertible
        {
            
            public LinkList<T> list;
            
            Node<T> top;
            


            public Stack()
            {
                list = new SingleLinkedList<T>();
                top = null;
                
                
            }
            public void Push(T item)
            {

                
                Node<T> push_Node = new Node<T>(item);
                push_Node.data = item;
                
                if (top == null)
                {
                    top = push_Node;
                    top.next = null;
                    return;
                }
                    
                
                push_Node.next = top;
                top = push_Node;
                list.SetHead(top);
                
            }
            public T Pop()
            {
                list.SetHead(top);
                T item = top.data;
                list.RemoveFirst();
                top = list.GetHead();
                return item;
            }
            public T Peek()
            {

                return top.data;
                
            }
            public Boolean IsEmpty()
            {
                return top == null;
            }
            public int Size()
            {
                list.SetHead(top);
                return list.Size();
            }
        }

        /// <summary>
        /// Queue using link list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class Queue<T> where T : IComparable, IConvertible
        {
            Node<T> front,rear;
            LinkList<T> list;
            public Queue()
            {
                list = new SingleLinkedList<T>();
                front = null;
                rear = null;
            }
            public void Enqueue(T item)
            {
                list.SetHead(front);
                list.InsertEnd(item);
                rear = list.GetLastNode();
                front = list.GetFirstNode();
            }
            public T Dequeue()
            {
                list.SetHead(front);
                T item = front.data;
                front = front.next;
                return item;

            }
            public Boolean IsEmpty()
            {
                return front == null;
            }
            public int Size()
            {
                list.SetHead(front);
                return list.Size();
            }


        }

        /// <summary>
        /// Dequeue using link list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class Dequeue<T> where T : IComparable, IConvertible
        {
            Node<T> front; 
            Node<T> rear;
            LinkList<T> list;
            public Dequeue()
            {
                list = new SingleLinkedList<T>();
                front = null;
                rear = null;
            }

            public void AddFront(T item)
            {
                list.SetHead(front);
                list.InsertFront(item);
                front = list.GetFirstNode();
                rear = list.GetLastNode();

            }
            public void AddRear(T item)
            {
                list.SetHead(front);
                list.InsertEnd(item);
                front = list.GetFirstNode();
                rear = list.GetLastNode();

            }
            public T RemoveFront()
            {
                list.SetHead(front);
                T item = front.data;
                list.RemoveFirst();
                front = list.GetFirstNode();
                rear = list.GetLastNode();
                return item;
            }
            public T RemoveRear()
            {
                list.SetHead(front);
                T item = front.data;
                list.RemoveLast();
                front = list.GetFirstNode();
                rear = list.GetLastNode();
                return item;

            }
            public Boolean IsEmpty()
            {
                return front == null; 
            }
            public int Size()
            {
                list.SetHead(front);
                return list.Size();
            }

        }

        /// <summary>
        /// Hash using orderd link list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class Hash<T> where T : IComparable, IConvertible
        {
            public OrderedList<T>[] hashTableSlot;
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
            public void Add(T key)
            {
                int hashFunctionSize = this.size + 1;
                int slot = Convert.ToInt32(key) % hashFunctionSize;
                hashTableSlot[slot].Add(key);
            }
            public Boolean Search(T key)
            {
                int hashFunctionSize = this.size + 1;
                int slot = Convert.ToInt32(key) % hashFunctionSize;
                return hashTableSlot[slot].Search(key);
            }
            public void Remove(T key)
            {
                int hashFunctionSize = this.size + 1;
                int slot = Convert.ToInt32(key) % hashFunctionSize;
                hashTableSlot[slot].Remove(key);

            }
        }







    }
}
