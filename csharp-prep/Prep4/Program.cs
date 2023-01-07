using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, enter 0 when you're done.");
        Console.Write("Enter a number: ");
        string output = Console.ReadLine();
        int number = int.Parse(output);

        List<int> newList = new List<int>();
        
        while (number != 0)
        {
            newList.Add(number);

            Console.Write("Enter a number: ");
            output = Console.ReadLine();
            number = int.Parse(output);
        }
        
        if (newList[0] != 0)
        {
            int largestNumber = -1; 
            float average = 0; 
            int sum = 0; 

            foreach (int numbers in newList)
            {
                sum = sum + numbers; 

                if (numbers > largestNumber)
                {
                    largestNumber = numbers;
                }
            }

            average = ((float)sum) / newList.Count;

            Console.WriteLine($"The average is {average}, the sum is {sum} and the largest number is {largestNumber}.");
            
            Console.WriteLine("The Contents of the list are...");
            foreach (int digit in newList) 
            {
                Console.WriteLine(digit);
            }
        }

        newList.Clear();
        

    }
}