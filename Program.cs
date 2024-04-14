using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


public class exercise10
{
    public static void Main(string[] args)
    {
        Console.WriteLine("----------Task 1----------");
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] userArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            userArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Your array:");
        foreach( var i in userArray)
        {
            Console.Write(i + "\t");
        }
        Console.WriteLine();
        int maxElement = FindMaxElement(userArray);
        Console.WriteLine("The maximum element in the array is: " + maxElement);
        static int FindMaxElement(int[] array)
        {
            int maxElement = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {

                    maxElement = array[i];
                }
            }

            return maxElement;
        }
        Console.WriteLine("---------------------------");
        
        Console.WriteLine("----------Task 2-----------");

        static int[] ReverseArray(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;

            while (start < end)
            {

                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;


                start++;
                end--;
            }
            return array;
        }
        Console.WriteLine("Original array: ");
        foreach (int element in userArray)
        {
            Console.Write(element + "\t");
        }
        Console.WriteLine();

        int[] reversedArray = ReverseArray(userArray);
        Console.WriteLine("Reversed array: ");
        foreach (int element in reversedArray)
        {
            Console.Write(element + "\t");
        }
        Console.WriteLine();
        Console.WriteLine("---------------------------");
        
        Console.WriteLine("----------Task 3-----------");

        Console.WriteLine("Array elements:");
        foreach (int element in userArray)
        {
            Console.Write(element + "\t");
        }
        int sum = 0;
        foreach (int element in userArray)
        {
            sum = sum + element;
        }
        Console.WriteLine();
        Console.WriteLine("The sum of elements of the array: "+sum);
        Console.WriteLine("---------------------------");
    }
}
