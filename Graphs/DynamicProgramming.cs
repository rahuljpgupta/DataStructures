using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{

    class Item
    {
        public int Value { get; set; }
        public int Weight { get; set; }
        public Item(int value,int weight)
        {
            Value = value;
            Weight = weight;
        }
    }
    class DynamicProgramming
    {
        public int KnapSack(List<Item> items, int capacity)
        {
            int itemsCount = items.Count();
            int[,] arr = new int[itemsCount+1, capacity+1];
            List<Item> solution = new List<Item>();
            for (int i = 0; i <= capacity; i++)
                arr[0, i] = 0;
            for (int i = 1; i <= itemsCount; i++)
            {
                for(int j=0;j<=capacity;j++)
                {
                    if (j - items[i-1].Weight>=0)
                    {
                        arr[i, j] = Math.Max(arr[i - 1, j], arr[i - 1, j - items[i-1].Weight] + items[i-1].Value); 
                    }
                    else
                    {
                        arr[i, j] = arr[i - 1, j];
                    }
                }
            }
            //Below code tracebacks the optimal solution
            int k = capacity;
            for (int i=itemsCount;i>0;i--)
            {
                if(arr[i,k]!=arr[i-1,k])
                {
                    solution.Add(items[i-1]);
                    k = k - items[i-1].Weight;
                }
            }
            return arr[itemsCount , capacity];
        }
        
    }
}
