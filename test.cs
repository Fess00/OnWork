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

        // int[] arr = {6, 2, 76, 22, 1, 88, 90, 45};
        // Console.WriteLine(arr.Length);
        // Working.QSort(arr, 0, arr.Length);

        int[] arr_1 = {7,1,5,3,6,4};
        Console.WriteLine(LeetCode.MaxProfit(arr_1));

        string str = "0PP";
        LeetCode.IsPalindrome(str);


        Console.ReadKey();
    }
}

public static class Working {
    
    public static void QSort(int[] list, int first, int last) {
        if (first + last < 2)
            return;
        int pivot = (first + last) / 2;
        int b = first;
        int e = last;
        while (first < last - 1) {
            if (list[first] > list[last - 1]) {
                int tmp = list[first];
                list[first] = list[last - 1];
                list[last - 1] = tmp;
            }
            Console.WriteLine(list[first] + " " + list[last - 1]);
            first++;
            last--;
        }
        QSort(list, b, pivot);
        QSort(list, pivot, e);
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
}