using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
    public class Graph
    {
        LinkedList<Node>[] graph = new LinkedList<Node>[50];
        Dictionary<string, int> indexes = new Dictionary<string, int>();
        int size = 0;
        private class Node
        {
            public string label { get; set; }
        }

        public void addNode(string label)
        {
            if (NodeExists(label))
                return;

            indexes.Add(label, size);

            graph[size++] = new LinkedList<Node>();
        }
        public void removeNode(string label)
        {
            if (!NodeExists(label))
                return;

            int indexToRemove;
            indexes.TryGetValue(label, out indexToRemove);

            removeIndex(label);

            graph[indexToRemove] = new LinkedList<Node>();

            removeEdgeFromEveryNode(label);
       

        }
        private void removeEdgeFromEveryNode(string label)
        {
            Node nodeToDelete = null;
            foreach (var Node in graph)
            {
                foreach (var Edge in Node)
                {
                    if (Edge.label == label)
                    {
                        nodeToDelete = Edge;
                        break;
                    }
                }
                if (nodeToDelete != null)
                    Node.Remove(nodeToDelete);

                nodeToDelete = null;
            }
        }

        public void addEdge(string from, string to)
        {
            if (!NodeExists(from) || !NodeExists(to))
                return;


            int indexToAddEdge;
            indexes.TryGetValue(from, out indexToAddEdge);

            //int indexToBeAdded;
            //indexes.TryGetValue(to, out indexToBeAdded);

            var edges = graph[indexToAddEdge];

            edges.AddLast(new Node() { label = to });

            graph[indexToAddEdge] = edges;
        }
        public void removeEdge(string from, string to)
        {
            if (!NodeExists(from) || !NodeExists(to))
                return;

            int indexToRemoveEdge;
            indexes.TryGetValue(from, out indexToRemoveEdge);

            //int indexToBeAdded;
            //indexes.TryGetValue(to, out indexToBeAdded);

            var edges = graph[indexToRemoveEdge];
            var nodeToRemove = getNodeToRemove(edges, to);
            graph[indexToRemoveEdge].Remove(nodeToRemove);


        }
        public void print()
        {
            foreach (var item in indexes)
            {
                Console.WriteLine($"{item.Key} is connected with");
                foreach (var edge in graph[item.Value])
                {
                    Console.Write($"{edge.label} ");
                }
            }
        }
        private Node getNodeToRemove(LinkedList<Node> List, string label)
        {
            foreach (var item in List)
            {
                if (item.label == label)
                    return item;
            }

            return new Node();
        }
        private void removeIndex(string label)
        {
            indexes.Remove(label);
        }

        private bool NodeExists(string label)
        {
            if (label == null)
                return false;

            return indexes.ContainsKey(label);
        }
    }
}
