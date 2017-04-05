using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Heap
    {
        public List<HeapNode> nodeList=new List<HeapNode>();
        public void SampleHeap()
        {
            HeapNode root, node1, node2, node3, node4, node5, node6, node7, node8;
            root = new HeapNode(4, "Root");
            node1 = new HeapNode(4, "node1");
            node2 = new HeapNode(8, "node2");
            node3 = new HeapNode(9, "node3");
            node4 = new HeapNode(4, "node4");
            node5 = new HeapNode(12, "node5");
            node6 = new HeapNode(9, "node6");
            node7 = new HeapNode(11, "node7");
            node8 = new HeapNode(13, "node8");
            nodeList = new List<HeapNode>() { root, node1, node2, node3, node4, node5, node6, node7, node8 };
        }
        public int Parent(int index)
        {
            int parentIndex = (int)Math.Floor(((double)index+1) / 2)-1;
            if (parentIndex == -1)
                return -1;
            return parentIndex;
        }
        public int LeftChild(int index)
        {
            if (index == -1)
                return -1;
            int leftIndex = (2 * (index + 1))-1;
            if (leftIndex > nodeList.Count - 1)
                return -1;
            return leftIndex;
        }
        public int RightChild(int index)
        {
            if (index == -1)
                return -1;
            int rightIndex = (2 * (index + 1));
            if (rightIndex > nodeList.Count - 1)
                return -1;
            return rightIndex;
        }
        public HeapNode ExtractMin()
        {
            HeapNode outNode = nodeList[0];
            nodeList[0] = nodeList[nodeList.Count - 1];
            nodeList.RemoveAt(nodeList.Count - 1);
            
            
            int index = 0;
            int leftChildIndex = LeftChild(index);
            int rightChildIndex = RightChild(index);
            while (leftChildIndex!=-1 || rightChildIndex!=-1)
            {
                HeapNode tempNode;
                if (leftChildIndex != -1 && rightChildIndex != -1)
                {
                    
                    if (nodeList[index].Key > nodeList[leftChildIndex].Key || nodeList[index].Key > nodeList[rightChildIndex].Key)
                    {
                        
                        if (nodeList[leftChildIndex].Key <= nodeList[rightChildIndex].Key)
                        {
                            tempNode = nodeList[index];
                            nodeList[index] = nodeList[LeftChild(index)];
                            nodeList[leftChildIndex] = tempNode;
                            index = leftChildIndex;
                        }
                        else
                        {
                            tempNode = nodeList[index];
                            nodeList[index] = nodeList[rightChildIndex];
                            nodeList[rightChildIndex] = tempNode;
                            index = rightChildIndex;
                        }
                    } 
                }
                else if(leftChildIndex != -1)
                {
                    if (nodeList[index].Key>=nodeList[leftChildIndex].Key)
                    {
                        tempNode = nodeList[index];
                        nodeList[index] = nodeList[leftChildIndex];
                        nodeList[leftChildIndex] = tempNode;
                         
                    }
                    index = leftChildIndex;
                }
                else if(rightChildIndex != -1)
                {
                    if (nodeList[index].Key>=nodeList[rightChildIndex].Key)
                    {
                        tempNode = nodeList[index];
                        nodeList[index] = nodeList[rightChildIndex];
                        nodeList[rightChildIndex] = tempNode;
                         
                    }
                    index = rightChildIndex;
                }
                
                leftChildIndex = LeftChild(index);
                rightChildIndex = RightChild(index);
            }
            return outNode;
        }
        public void Delete(int key)
        {
            int index = 0;
            for(int i=0;i< nodeList.Count;i++)
            {
                if (nodeList[i].Key == key)
                {
                    index = i;
                    break;
                }
            }
            HeapNode outNode = nodeList[index];
            nodeList[index] = nodeList[nodeList.Count - 1];
            nodeList.RemoveAt(nodeList.Count - 1);

            //int index = 0;
            int leftChildIndex = LeftChild(index);
            int rightChildIndex = RightChild(index);
            while (leftChildIndex != -1 || rightChildIndex != -1)
            {
                HeapNode tempNode;
                if (leftChildIndex != -1 && rightChildIndex != -1)
                {

                    if (nodeList[index].Key > nodeList[leftChildIndex].Key || nodeList[index].Key > nodeList[rightChildIndex].Key)
                    {

                        if (nodeList[leftChildIndex].Key <= nodeList[rightChildIndex].Key)
                        {
                            tempNode = nodeList[index];
                            nodeList[index] = nodeList[LeftChild(index)];
                            nodeList[leftChildIndex] = tempNode;
                            index = leftChildIndex;
                        }
                        else
                        {
                            tempNode = nodeList[index];
                            nodeList[index] = nodeList[rightChildIndex];
                            nodeList[rightChildIndex] = tempNode;
                            index = rightChildIndex;
                        }
                    }
                }
                else if (leftChildIndex != -1)
                {
                    if (nodeList[index].Key >= nodeList[leftChildIndex].Key)
                    {
                        tempNode = nodeList[index];
                        nodeList[index] = nodeList[leftChildIndex];
                        nodeList[leftChildIndex] = tempNode;

                    }
                    index = leftChildIndex;
                }
                else if (rightChildIndex != -1)
                {
                    if (nodeList[index].Key >= nodeList[rightChildIndex].Key)
                    {
                        tempNode = nodeList[index];
                        nodeList[index] = nodeList[rightChildIndex];
                        nodeList[rightChildIndex] = tempNode;

                    }
                    index = rightChildIndex;
                }

                leftChildIndex = LeftChild(index);
                rightChildIndex = RightChild(index);
            }
        }
        public List<HeapNode> HeapSort()
        {
            List<HeapNode> sortedList = new List<HeapNode>();
            int count=nodeList.Count;
            for(int i=0;i<count;i++)
            {
                sortedList.Add(ExtractMin());
            }
            return sortedList;
        }

        public bool Insert(HeapNode newNode)
        {
            nodeList.Add(newNode);
            int newIndex = nodeList.Count - 1;
            while(newIndex != 0 && newNode.Key<=nodeList[Parent(newIndex)].Key )
            {
                HeapNode tempNode;
                tempNode = nodeList[newIndex];
                nodeList[newIndex] = nodeList[Parent(newIndex)];
                nodeList[Parent(newIndex)] = tempNode;
                newIndex = Parent(newIndex);

            }
            return true;
        }
    }
    class HeapNode
    {
        //public static HeapNode root;
        public int Key { get; set; }
        public string Value { get; set; }
        public HeapNode(int key, string value = "Default")
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
