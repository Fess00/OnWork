using System;
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

        // int[] arr = {6, 2, 76, 22, 1, 88, 90, 45};
        // Console.WriteLine(arr.Length);
        // Working.QSort(arr, 0, arr.Length);

        int[] arr_1 = {7,1,5,3,6,4};
        Console.WriteLine(LeetCode.MaxProfit(arr_1));

        string str = "0PP";
        LeetCode.IsPalindrome(str);

        int[][] matrix = new int[5][];
        matrix[0] = new int[5];
        matrix[1] = new int[5];
        matrix[2] = new int[5];
        matrix[3] = new int[5];
        matrix[4] = new int[5];
        Console.WriteLine(matrix.Length);

        Console.ReadKey();
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

    public int Size() {
        return index - 1;
    }

    public int Capacity() {
        return this.size;
    }
}

public static class LeetCode {
    public static int MaxProfit(int[] prices) {
        int max = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                if (prices[j] - prices[i] > max)
                    max = prices[j] - prices[i];
            }
        }
        return max;
    }

    public static bool ContainsDuplicate(int[] nums) {
        bool inside = false;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    inside =  true;
                    break;
                }
            }
        }
        return inside;
    }

    public static bool IsPalindrome(string s) {
        s = s.ToLower();
        int realLength = s.Length - 1;
        int index = 0;
        while (index < realLength) {
            Console.WriteLine(s[index] + " " + s[realLength]);
            if (char.IsLetter(s[index]) || char.IsNumber(s[index]))
            {
                if (char.IsLetter(s[realLength]) || char.IsNumber(s[realLength])) 
                {
                    if (s[realLength] != s[index]) {
                        return false;
                    }
                    index++;
                    realLength--;
                }
                else 
                {
                    realLength--;
                    continue;
                }
            }
            else
            {
                index++;
                continue;
            }
        }
        return true;
    }

    public static void Rotate(int[][] matrix) {
        int size = Math.Floor(matrix.Length / 2);
        for (int i = 0; i < size; i++)
        {
            for (int j = i; j < matrix.Length - i - 1; j++)
            {
                
            }
        }
    }
}

