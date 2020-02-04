using System;
using System.Collections.Generic;

namespace Lab3_3
{
    class Program
    {
        static Stack<char> stack = new Stack<char>();
        static char[] character;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to string reversal!");
            GetInput();
        }
        private static void GetInput()
        {
            Console.Write("Please enter the string you wish to reverse: ");
            string input = Console.ReadLine();
            ReverseString(input);
        }
        private static string ReverseString(string str)
        {
            character = str.ToCharArray();
                        for (int i = 0; i < character.Length; i++)
                        {

                            stack.Push(character[i]);
                        }

                        Console.WriteLine("Your new word is: ");
                        do
                        {
                            Console.Write(stack.Pop());
                        }
                        while (stack.Count > 0);
                        return str;
        }


    }
}
