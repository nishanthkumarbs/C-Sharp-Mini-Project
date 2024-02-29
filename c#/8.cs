using System;
using System.Collections.Generic;

namespace StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            while (true)
            {
                Console.WriteLine("Enter 'push' to add an element to the stack, 'pop' to remove an element, or 'exit' to quit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }

                if (input.ToLower() == "push")
                {
                    Console.Write("Enter the value to push onto the stack: ");
                    int value = Convert.ToInt32(Console.ReadLine());
                    stack.Push(value);
                    Console.WriteLine($"Pushed {value} onto the stack.");
                }
                else if (input.ToLower() == "pop")
                {
                    try
                    {
                        int value = stack.Pop();
                        Console.WriteLine($"Popped {value} from the stack.");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }
    }

    public class Stack
    {
        private List<int> data;

        public Stack()
        {
            data = new List<int>();
        }

        public int Count
        {
            get { return data.Count; }
        }

        public void Push(int item)
        {
            data.Add(item);
        }

        public int Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            int lastIndex = data.Count - 1;
            int item = data[lastIndex];
            data.RemoveAt(lastIndex);
            return item;
        }
    }
}
