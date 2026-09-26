using System.Collections;
using System.Runtime.CompilerServices;

namespace Assign1Advanced;

class Program
{
    public static void ReverseList(ArrayList arrayList)
    {
        int left = 0;
        int right = arrayList.Count - 1;

        while (left < right)
        {
            (arrayList[right] , arrayList[left]) = (arrayList[left], arrayList[right]);
            left++;
            right--;
        }
    }

    public static List<int> EvenNumbers(List<int> numbers)
    {
        List<int> evenNumbers = new List<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 == 0)
                evenNumbers.Add(numbers[i]);
        }
        return evenNumbers;
    }

    public static int FirstNonRepeatedChar(string text)
    {
        text = text.ToLower();
        
        Dictionary<char, int> dict = new Dictionary<char, int>();

        for (int i = 0; i < text.Length; i++)
        {
            if(dict.ContainsKey(text[i]))
                dict[text[i]]++;
            else
                dict.Add(text[i], 1);
        }

        for (int i = 0; i < text.Length; i++)
        {
            if (dict[text[i]] == 1)
                return i;
        }

        return -1;
    }

    static void Main(string[] args)
    {

        #region Optimized Bubble Sort

        // int[] numbers = { 1, 2, 3, 5, 4 };
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     bool swapped = false;
        //     for (int j = 0; j < numbers.Length - 1 - i; j++)
        //     {
        //         if (numbers[j] > numbers[j + 1])
        //         {
        //             (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
        //             swapped = true;
        //         }
        //     }
        //     if (!swapped)
        //         break;
        // }
        //
        // Console.WriteLine("Sorted Array:");
        // foreach (int number in numbers)
        // {
        //     Console.Write(number + " ");
        //     
        //
        // }
        #endregion

        #region Generic Range

        // Range<int> range = new Range<int>(10, 20);
        // Console.WriteLine(range.IsInRange(15));
        // Console.WriteLine(range.IsInRange(30));
        // Console.WriteLine(range.Length());

        #endregion

        #region Reverse the order of elements in the ArrayList in-place

        // ArrayList arrayList = new ArrayList(){1 , 2 , 3 , 4 , 5 , "Mokhtar"};
        // ReverseList(arrayList);
        // foreach (var item in arrayList)
        // {
        //     Console.WriteLine(item);
        // }

        #endregion

        #region Even Numbers

        // List<int> list = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        // List<int> evenNumbers =  EvenNumbers(list);
        //
        // foreach (int number in evenNumbers)
        // {
        //     Console.WriteLine(number);
        // }

        #endregion

        #region Fixed Size List

        // FixedSizeList<int> list = new FixedSizeList<int>(3);
        //
        // list.Add(10);
        // list.Add(20);
        // list.Add(30);
        //
        // Console.WriteLine(list.Get(0)); 
        // Console.WriteLine(list.Get(1)); 
        // Console.WriteLine(list.Get(2)); 
        
        // list.Add(40);
        // Console.WriteLine(list.Get(3));

        #endregion

        string text = "Mohammed";
        Console.WriteLine(FirstNonRepeatedChar(text));



    }
    
}