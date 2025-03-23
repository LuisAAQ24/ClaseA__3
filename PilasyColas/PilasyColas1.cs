using System;
using System.Collections.Generic;

// Common interface for stacks
public interface IStack
{
    void Push(int element);
    int Pop();
    int Top();
    bool IsEmpty();
}

// Stack implementation using an array
public class ArrayStack : IStack
{
    private int[] stack;
    private int top;

    public ArrayStack(int size)
    {
        stack = new int[size];
        top = -1;
    }

    public void Push(int element)
    {
        if (top == stack.Length - 1)
            throw new InvalidOperationException("Stack Overflow");
        stack[++top] = element;
    }

    public int Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack Underflow");
        return stack[top--];
    }

    public int Top()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack Underflow");
        return stack[top];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }
}

// Stack implementation using a linked list
public class LinkedListStack : IStack
{
    private class Node
    {
        public int Data;
        public Node Next;
        public Node(int data) { Data = data; Next = null; }
    }

    private Node top;

    public void Push(int element)
    {
        Node newNode = new Node(element);
        newNode.Next = top;
        top = newNode;
    }

    public int Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack Underflow");
        int data = top.Data;
        top = top.Next;
        return data;
    }

    public int Top()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack Underflow");
        return top.Data;
    }

    public bool IsEmpty()
    {
        return top == null;
    }
}

// Common interface for queues
public interface IQueue
{
    void Enqueue(int element);
    int Dequeue();
    int Front();
    bool IsEmpty();
}

// Queue implementation using an array
public class ArrayQueue : IQueue
{
    private int[] queue;
    private int front;
    private int rear;

    public ArrayQueue(int size)
    {
        queue = new int[size];
        front = -1;
        rear = -1;
    }

    public void Enqueue(int element)
    {
        if (rear == queue.Length - 1)
            throw new InvalidOperationException("Queue Overflow");
        if (front == -1) front = 0;
        queue[++rear] = element;
    }

    public int Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue Underflow");
        int element = queue[front];
        if (front == rear) front = rear = -1;
        else front++;
        return element;
    }

    public int Front()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue Underflow");
        return queue[front];
    }

    public bool IsEmpty()
    {
        return front == -1;
    }
}

// Queue implementation using a linked list
public class LinkedListQueue : IQueue
{
    private class Node
    {
        public int Data;
        public Node Next;
        public Node(int data) { Data = data; Next = null; }
    }

    private Node front;
    private Node rear;

    public void Enqueue(int element)
    {
        Node newNode = new Node(element);
        if (rear == null)
        {
            front = rear = newNode;
        }
        else
        {
            rear.Next = newNode;
            rear = newNode;
        }
    }

    public int Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue Underflow");
        int data = front.Data;
        front = front.Next;
        if (front == null) rear = null;
        return data;
    }

    public int Front()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue Underflow");
        return front.Data;
    }

    public bool IsEmpty()
    {
        return front == null;
    }
}
