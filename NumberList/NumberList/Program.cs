using System;
using System.Collections.Generic;

public class Program
{
    public static async Task<List<int>> GenerateAsyncNumberList()
    {
        List<int> numbers = new List<int>();

        for (int n = 1; n <= 100; n++)
        {
            numbers.Add(n);
            await Task.Delay(100);
        }
        
        return numbers;
    }
    public static async Task<List<int>> FilteringEvenAsyncNumbersInList(List<int> numbers)
    {
        return await Task.Run(() =>
        {
            List<int> evenNumbers = new List<int>();
            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    evenNumbers.Add(n);
                }
            }
            return evenNumbers;
        });
    }
    public static async Task Main()
    {
        try
        {
            List<int> numbers = await GenerateAsyncNumberList();
            List<int> evenNumbers = await FilteringEvenAsyncNumbersInList(numbers);

            Console.WriteLine("Numerele pare sunt: ");
            foreach (int n in evenNumbers)
            {
                Console.WriteLine(n);
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine($"A aparut o eroare {exception}");
        }
    }
}