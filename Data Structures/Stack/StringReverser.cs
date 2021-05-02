using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
    class StringReverser
    {
        public string reverse(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentNullException();  

            Stack<char> stack = new Stack<char>();
            StringBuilder result = new StringBuilder();

            foreach(char letter in text)
                stack.Push(letter);

            while (stack.Count > 0)
                result.Append(stack.Pop());


            //result = string.Join("", stack.ToArray());

            return result.ToString();
        }

        public bool isBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach(var letter in input)
            {
                if (letter == '(')
                    stack.Push(letter);

                else if(letter == ')')
                {
                    if (stack.Count == 0) return false;

                    stack.Pop();

                }
                        
            }

            return stack.Count == 0;
        }
    }
}
