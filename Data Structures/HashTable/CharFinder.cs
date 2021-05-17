using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
    class CharFinder
    {
        public  char firstNonRepeatedCharacter(string text)
        {
            var dictionary = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                //if (dictionary.ContainsKey(text[i]))
                //{
                //    int oldValue = dictionary[text[i]];
                //    dictionary[text[i]] = ++oldValue;
                //}
                //else
                //{
                //    dictionary[text[i]] = 1;
                //}

                var key = text[i];
                var count = dictionary.ContainsKey(key) ? dictionary[key] : 0;

                dictionary[key] = count + 1;
            }

            foreach (var item in dictionary)
            {
                if (item.Value == 1)
                {
                    return item.Key;
                }
            }

            return char.MinValue;
        }
        public char firstRepeatedCharacter(string text)
        {
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < text.Length; i++)
            {
                if (set.Contains(text[i]))
                    return text[i];
                    
                set.Add(text[i]);

            }

            return char.MinValue;
        }
    }
}
