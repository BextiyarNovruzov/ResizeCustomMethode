using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3 }; 
        InsertArray(ref numbers, 4, 5, 6);  
   }

    static void InsertArray(ref int[] array, params int[] values)
    {
        int originalLength = array.Length;  
        int newLength = originalLength + values.Length;  
        int[] newArray = new int[newLength];

        for (int i = 0; i < originalLength; i++)
        {
            newArray[i] = array[i];
        }

        for (int i = 0; i < values.Length; i++)
        {
            newArray[originalLength + i] = values[i];
        }

        array = newArray;

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
