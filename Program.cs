using System;


class Program
{
    
    static int getOutputArrayLength (string[] inputArray) {
        
        int outputArraySize = 0;
        
        for (int i = 0; i < inputArray.Length; ++i)
        {
            if (inputArray[i].Length < 4)
            {
                ++outputArraySize;
            }
        }
        return outputArraySize;
    }
    
    static void Main() {
        
        string[] inputArray = new string[] { "hello", "2", "world", ":-)", "1234", "156", "-2", "computer science", "Russia", "Denmark", "Kazan"};
        int outputArrayIndex = 0;
        string[] outputArray = new string[getOutputArrayLength(inputArray)];
        
        
        for (int i = 0; i < inputArray.Length; ++i)
        {
            if (inputArray[i].Length < 4)
            {
                outputArray[outputArrayIndex] = inputArray[i];
                ++outputArrayIndex;
            }
        }

        Console.Write("['");
        Console.Write(string.Join("' , '", outputArray));
        Console.WriteLine("']");
    }
}