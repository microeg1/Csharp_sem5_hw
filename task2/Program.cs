using System;


class Program

{
    static void FillArray(int[] collection)
    {
        int length = collection.Length;
        int index = 0;
     while (index < length)
        {
            collection[index] = new Random().Next();
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
        int sum = 0;

        while (index < length)
        {
            if (index%2 > 0)
            {
                sum = array[index] + sum;
            }
            index++;
        }
        Console.WriteLine(" ");
        Console.WriteLine("Сумма чисел стоящих на нечётных позициях равна: " + sum + ".");
    }
}