﻿
namespace WiredBrainCoffe.StackApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackDoubles();
            StackStrings();


            Console.ReadLine();
        }

        private static void StackDoubles()
        {
            var stack = new Stack<double>(); //type safe
            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);

            double sum = 0.0;

            while (stack.Count > 0)
            {
                double item = (double)stack.Pop();
                Console.WriteLine($"Item: {item}");
                sum += item;
            }

            Console.WriteLine($"Sum: {sum}");
        }

        private static void StackStrings()
        {
            var stack = new Stack<string>(); //type safe
            stack.Push("Wired Brain Coffee");
            stack.Push("Pluralsight");

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

        }
    }
}
