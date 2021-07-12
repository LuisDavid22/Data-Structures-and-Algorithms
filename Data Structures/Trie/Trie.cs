using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
    public class Trie
    {
        private Node root;
        public Trie()
        {
            root = new Node(' ');
        }
        private class Node
        {
            public char value { get; set; }
            public Dictionary<char, Node> children { get; set; }
            public bool isEndOfWord { get; set; }

            public Node(char value, bool isEndOfWord = false)
            {
                this.value = value;
                children = new Dictionary<char, Node>();
                this.isEndOfWord = isEndOfWord;
            }
            public bool hasChild(char letter)
            {
                return children.ContainsKey(letter);
            }
            public void addChild(char letter)
            {
                children.Add(letter, new Node(letter));
            }
            public Node getChild(char letter)
            {
                return children[letter];
            }
            public Node[] getChildren()
            {
                return children.Values.ToArray();
            }

        }

        public void insert(string word)
        {
            var current = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (!current.hasChild(word[i]))
                    current.addChild(word[i]);

                current = current.getChild(word[i]);
            }

            current.isEndOfWord = true; 
        }

        public bool contains(string word)
        {
            var current = root;

            for (int i = 0; i < word.Length; i++)
            {
                if (current.hasChild(word[i]))
                {
                    current = current.getChild(word[i]);
                    continue;
                }
                   
                return false;
            }

            return current.isEndOfWord;

        }
     
        public void traverse()
        {
            traverse(root);
        }
        private void traverse(Node node)
        {
            Console.WriteLine(node.value);

            foreach (var child in node.getChildren())
            {
                traverse(child);
            }
        }
        public void delete (string word)
        {
            if (!root.hasChild(word[0]))
                return;

            delete(root.getChild(word[0]), word);
        }
        private void delete(Node node, string word)
        {
            foreach (var child in node.getChildren())
                delete(child, word);

            if(node.value == word[word.Length - 1])
            {

            }
        }
    }
}
