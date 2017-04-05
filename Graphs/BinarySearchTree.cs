using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class BinarySearchTree
    {
        Node root; 
        Node node2;
        Node node3;
        Node node4;
        Node node5;
        Node node6;
        Node node7;
        Node node8;
        public BinarySearchTree()
        {
            root = new Node(10);
            node2 = new Node(5,root);
            node3 = new Node(15,root);
            node4 = new Node(5,node2);
            node5 = new Node(7,node2);
            node6 = new Node(13,node3);
            node7 = new Node(18,node3);
            node8 = new Node(1,node4);

            root.LeftChild = node2;
            root.RightChild = node3;
            node2.LeftChild = node4;
            node2.RightChild = node5;
            node3.LeftChild = node6;
            node3.RightChild = node7;
            node4.LeftChild = node8;   
        }
        public Node Search(int key)
        {
            Node node = root;
            while(node.LeftChild!=null || node.RightChild!=null)
            {
                if(node.Key==key)
                    return node;
                else if (key<node.Key)
                    node = node.LeftChild;
                else
                    node = node.RightChild;
            }
            if (node.Key == key)
                return node;
            return null;
        }
        public Node Minimum()
        {
            Node node = root;
            while(node.LeftChild!=null)
            {
                node = node.LeftChild;
            }
            return node;
        }
        public bool Insert(Node newNode)
        {
            //object node = root;
            Node node = root;
            while (node.LeftChild != null || node.RightChild != null)
            {
                if (node.LeftChild == null)
                {
                    node.LeftChild = newNode;
                    return true; 
                }
                else if (newNode.Key <= node.Key)
                    node = node.LeftChild;
                else
                    node = node.RightChild;
            }
            if (node.LeftChild == null)
                node.LeftChild = newNode;
            else if (node.RightChild == null)
                node.RightChild = newNode;
            return true;
        }
    }
    class Node
    {
        public int Key { get; set; }
        public string Value { get; set; }
        public Node Parent { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public Node(int key, Node parent=null, string value="Default")
        {
            Key = key;
            Value = value;
            Parent = parent;
        }
    }
}
