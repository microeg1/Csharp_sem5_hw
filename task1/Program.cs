using System;


class Program

{
    static void FillArray(int[] collection)
    {
        int length = collection.Length;
        int index = 0;
     while (index < length)
        {
            collection[index] = new Random().Next(99,1000);
            index++;
        }
    }
    static void PrintArray(int[] col)           
    {
        int count = col.Length;
        int position = 0;
        while(position < count)
        {
            Console.Write(col[position] + ", ");
            position++;
        }
    } 
    static void Main(string[] args)
    {
        int[] array = new int[10];
        FillArray(array);
        PrintArray(array);
        int index = 0;
        int length = array.Length;
        int count = 0;

        while (index < length)
        {
            if (array[index]%2 == 0)
            {
                count++;
            }
            index++;
        }
        Console.WriteLine(" ");
        Console.WriteLine("В массиве " + count + " четных чисел.");
    }
}