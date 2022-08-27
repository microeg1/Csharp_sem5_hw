using System;


class Program

{
    static void FillArray(double[] collection)
    {
        int length = collection.Length;
        int index = 0;
     while (index < length)
        {
            collection[index] = new Random().Next(1,10);
            index++;
        }
    }
    static void PrintArray(double[] col)        
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
        double[] array = new double[10];
        FillArray(array);
        PrintArray(array);
        int index = 0;
        int length = array.Length;
        double max = 0;
        double min = 0;
        double sum = 0;

        while (index < length)
        {
            if (array[index] > max)
            {
               max = array[index];
            }
            if (array[index] < min)
            {
               min = array[index];
            }
            
            index++;
        }
        sum = max - min;
        Console.WriteLine(" ");
        Console.WriteLine("Разница между максимальным и минимальным числом списка равна: " + sum + ".");
    }
}