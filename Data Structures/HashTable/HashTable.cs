using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
    public class HashTable
    {
        static int size = 10;
        LinkedList<Entry>[] items = new LinkedList<Entry>[size];
        class Entry
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }
        
        public void put(int k, string v)
        {
            var index = hash(k);

            if (items[index] == null)
                items[index] = new LinkedList<Entry>();

            var bucket = items[index];
            foreach (var entry in bucket)
            {
                if (entry.Key == k)
                {
                    entry.Value = v;
                    return;
                }
            }
            bucket.AddLast(new Entry()
            {
                Key = k,
                Value = v
            });

        }
        private void upsert(int k, string v)
        {
            
        }
        //private void upsert(int k, string v)
        //{
        //    var index = hash(k);
        //    var currentList = items[index];

        //    if (currentList != null && currentList.Count > 0)
        //    {
        //        foreach (var item in currentList)
        //        {
        //            if (item.Key == k)
        //            {
        //                item.Value = v;
        //                return;
        //            }

        //        }

        //        currentList.AddLast(new Entry()
        //        {
        //            Key = k,
        //            Value = v
        //        });
        //    }
        //    else
        //    {
        //        currentList = new LinkedList<Entry>();

        //        currentList.AddLast(new Entry()
        //        {
        //            Key = k,
        //            Value = v
        //        });
        //    }
        

        //    items[index] = currentList;

        //}
        public string get(int k)
        {
            var index = hash(k);
            var currentList = items[index];

            if (currentList == null)
                return string.Empty;

            foreach (var item in currentList)
                if (item.Key == k)
                    return item.Value;

            return string.Empty;
        }
        public void remove(int k)
        {
            var index = hash(k);
            var currentList = items[index];

            if (currentList == null)
                return;

            foreach (var item in currentList)
            {
                if (item.Key == k)
                    currentList.Remove(item);

                return;
            }
        }
        private int hash(int key)
        {
            return key % size;
        }

    }
}
