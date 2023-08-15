using System;
using System.Drawing;
internal class test
{

    private static void Main(string[] args)
    {
        Stack<string> s = new Stack<string>(4);
        s.Put("Hi");
        string tmp = s.Get();
        Console.WriteLine(tmp);
        s.Put("1");
        s.Put("2");
        tmp = s.Get();
        Console.WriteLine(tmp);
        tmp = s.Get();
        Console.WriteLine(tmp);
        tmp = s.Get();
        Console.WriteLine(tmp);
        Console.ReadKey();
    }
}

public static class Working {
    
    public static void SomeFunc() {
        
    }

}

public class Stack<T> {
    private T[] data;
    private int index;
    private bool[] isEmpty;
    private int size; 

    public Stack(int size) {
        this.index = 0;
        this.size = size;
        this.data = new T[this.size];
        this.isEmpty = new bool[this.size];
        for (int i = 0; i < this.size; i++)
        {
            this.isEmpty[i] = true;
        }
    }

    public T Get() {
        T tmp = default(T);
        if (this.isEmpty[this.index] == false)
        {
            tmp = data[index];
            this.isEmpty[this.index] = true;
            if (index > 0)
            {
                index -= 1;
            }
        }
        return tmp;
    }

    public void Put(T item) {
        if (this.isEmpty[index] == true)
        {
            this.data[index] = item;
            this.isEmpty[index] = false;
        }
        else if (this.isEmpty[index] == false && this.index < this.size)
        {
            index++;
            this.data[index] = item;
            this.isEmpty[index] = false;
        }
    }
}