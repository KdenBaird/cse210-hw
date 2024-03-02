using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
            int response = -1;
            Console.WriteLine("Write a list of numbers, enter 0 when finished. ");
            while (response != 0)
            {
                Console.Write("Enter number: ");
        


         response = int.Parse(Console.ReadLine());
         
            if (response != 0) 
            {
                numbers.Add(response);          
            }

            int sum = 0;
            float average = 0;
            int max = numbers.Max();
            foreach (int number in numbers) 
            {
            sum += number;
            average = sum / numbers.Count;
            }
            
            if (response == 0) 
            {
            Console.WriteLine($"The sum is: {sum}!");
            Console.WriteLine($"The average is: {average}!");
            Console.WriteLine($"The largest number is: {max}!");
            }
        }
    }
}