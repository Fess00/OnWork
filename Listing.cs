using System;
public class TestList {
    public static void Main() {
        
    }
}

class Node<T> {
    Node<T> next;
    T item;

    public T Item {
        get {
            return item;
        }
        set {
            item = value;
        }
    }

    public Node<T> Next {
        get {
            return next;
        }
        set {
            next = value;
        }
    }
    
    public Node(T item = default(T), Node<T> next = null) {
        this.next = next;
        this.item = item;
    }
}

public class Listing<T> {
    Node<T> last;
    readonly Node<T> first;
    int size;

    public Listing(T item = default(T)) {
        first = new Node<T>(item);
        last = first;
        size = 1;
    }

    public void Add(T item) {
        last.Next = new Node<T>(item);
        size++;
    }

    public void AddAt(int index,T item) {
        if (index < 0)
            return;
        Node<T> tmp = new Node<T>(item);
        if (index == 0) {
            tmp.Next = this[index];
        }
        else {
            tmp.Next = this[index];
            this[index - 1].Next = tmp;
        }
        size++;
    }

    public void Remove(int index) {
        this[index - 1].Next = this[index + 1];
        size--; // refactor like in AddAt()
    }

    public T this[int index] {
        get {
            if (index < size) {
                Node<T> tmp = first;
                if (index == 0)
                {
                    return tmp;
                }
                for (int i = 1; i < index; i++)
                {
                    tmp = tmp.Next;
                }
                return tmp;
            }
            else {
                return default(T);
            }
        }
    }

    private Node<T> this[int index] {
        
    }
}