using System;

class Program {
    public static void Main (string[] args) {
        queue<string> myQueue = new queue<string>(5);
        Console.WriteLine(myQueue.dequeue());
        myQueue.enqueue("hello");
        myQueue.enqueue("hello2");
        myQueue.enqueue("hello3");
        myQueue.enqueue("hello4");
        myQueue.enqueue("hello5");
        myQueue.enqueue("hello6");
        myQueue.dequeue();
        myQueue.returnQueue();
    }
}

class queue<T> {
    private int maxSize = -1;
    private T[] data;
    private int back = 0;

    public queue(int maxSize) {
        this.maxSize = maxSize;
        data = new T[maxSize];
    }

    public void enqueue(T newItem) {
        if (back<maxSize) {
            data[back] = newItem;
            back++;
        } else {
            Console.WriteLine("Full queue!");
        }
    }

    public T dequeue() {
        if (back>0) {
            T first = data[0];
            back--;
            int index=0;
            foreach(T element in data) {
                if (index!=0) {
                    data[index-1] = element;
                }
                index++;
            }
            data[maxSize-1] = default(T);
            return first;
        } else {
            return default(T);
        }
    }

    public void returnQueue() {
        foreach (T s in data) {
            Console.WriteLine(s);
        }
    }
}