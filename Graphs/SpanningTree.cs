using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class SpanningTree
    {
        int[,] graph;
        public SpanningTree()
        {
            graph = new int[5, 5] { { 0, 2, 1, 6, 0 }, { 2, 0, 3, 0, 0 }, { 1, 2, 0, 5, 0 }, { 6, 0, 5, 0, 8 }, { 0, 0, 0, 8, 0 } };
        }
        public int[,] PrimsMinimumSpanningTree()
        {
            int[,] spanningTree = new int[5, 5] { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
            List<int> processedNodes = new List<int>() { 1 };
            List<int> unProcessedNodes = new List<int>() { 2, 3, 4, 5 };
            #region
            //Heap heapY = new Heap();
            //foreach(int i in unProcessedNodes)
            //{
            //    if(graph[i, startNode]!=0)
            //    {
            //        HeapNode heapNode = new HeapNode(graph[i, startNode], Convert.ToString(i));
            //        heapY.Insert(heapNode);
            //    }

            //}
            //while(processedNodes.Count<=5)
            //{
            //    var minNode = heapY.ExtractMin();
            //    processedNodes.Add(minNode.Key);
            //    int nodeName = Convert.ToInt32(minNode.Value);
            //    int oldNodeKey=0;
            //    for(int i=0;i<5;i++)
            //    {
            //        if (graph[nodeName, i] == minNode.Key)
            //            oldNodeKey = i;
            //    }
            //    spanningTree[oldNodeKey, nodeName] = minNode.Key;
            //    spanningTree[nodeName, oldNodeKey] = minNode.Key;

            //    for(int i=0;i<5;i++)
            //    {
            //        if(graph[i,minNode.Key]!=0)
            //        {

            //        }
            //    }
            //    foreach (int i in processedNodes)
            //    {
            //        foreach (int j in unProcessedNodes)
            //        {
            //            if (graph[i, j] != 0)
            //            {
            //                HeapNode heapNode = new HeapNode(graph[i, startNode], Convert.ToString(i));
            //                heapY.Insert(heapNode);
            //            } 
            //        }

            //    }
            #endregion
            while (unProcessedNodes.Count != 0)
            {
                int min = int.MaxValue;
                int node1 = 0;
                int node2 = 0;
                foreach (int i in processedNodes)
                {
                    foreach (int j in unProcessedNodes)
                    {
                        if (graph[i - 1, j - 1] != 0 && graph[i - 1, j - 1] < min)
                        {
                            min = graph[i - 1, j - 1];
                            node1 = i;
                            node2 = j;
                        }

                    }
                }
                spanningTree[node1 - 1, node2 - 1] = min;
                spanningTree[node2 - 1, node1 - 1] = min;
                processedNodes.Add(node2);
                unProcessedNodes.Remove(node2);
            }
            return spanningTree;
        }

        public int[,] KruskalSpanningTree()
        {
            List<int> edges=new List<int>();
            int[,] spanningTree = new int[5, 5];
            for (int i=0;i<5;i++)
            {
                for(int j=i;j<5;j++)
                {
                    if(graph[i,j]!=0)
                        edges.Add(graph[i, j]);
                }
            }
            List<int> sortedEdges = new List<int>();
            for(int i=0;i<6;i++)
            {
                int min = edges[0];
                foreach(int j in edges)
                {
                    if (min > j)
                        min = j;
                }
                sortedEdges.Add(min);
                edges.Remove(min);
            }
            foreach (int item in sortedEdges)
            { 
                for (int i = 0; i < 5; i++)
                {
                    for (int j = i; j < 5; j++)
                    {
                        if (graph[i, j] == item)
                            spanningTree[i, j] = item;
                    }
                } 
            }
            return spanningTree; 
        }
    }
}

