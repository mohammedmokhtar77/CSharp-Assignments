using System.Runtime.CompilerServices;

namespace Assign1Advanced;

class Program
{
    static void Main(string[] args)
    {

        #region Optimized Bubble Sort

        int[] numbers = { 1, 2, 3, 5, 4 };
        for (int i = 0; i < numbers.Length; i++)
        {
            bool swapped = false;
            for (int j = 0; j < numbers.Length - 1 - i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                    swapped = true;
                }
            }
            if (!swapped)
                break;
        }
        
        Console.WriteLine("Sorted Array:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
            

        }
        #endregion
        
    }
    
}