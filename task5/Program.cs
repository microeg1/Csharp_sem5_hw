using System;


class Program

{
    static void FillArray(int[] collection)
    {
        int length = collection.Length;
        int index = 0;
     while (index < length)
        {
            collection[index] = new Random().Next(1,10);
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
        int length = array.Length -1;
        int prod = 0;
        int count = 1;
        Console.WriteLine(" ");
        while (index < array.Length)
        {
            prod = array[index]*array[length];
            index++;
            length--;
            Console.WriteLine("Произведение " + count + " пары чисел равно:" + prod);
            count++;
        }
      
    }
}