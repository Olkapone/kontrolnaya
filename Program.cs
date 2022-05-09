using System;


class Program
{
    static void Main() {
        
        string[] inputArray = new string[] { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"};
        int size = inputArray.Length;
        string[] outputArray = new string[size];
        int minCount = 0;

        for (int i = 0; i < size; i++)
        {
            if (inputArray[i].Length < 4)
            {
                
                outputArray[minCount] = inputArray[i];
                minCount++;
            }
        }

        Console.Write("[");
        Console.Write(string.Join(",", outputArray));
        Console.WriteLine("]");
    }
}
