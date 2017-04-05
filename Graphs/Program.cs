using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item(3, 4);
            Item item2 = new Item(2, 3);
            Item item3 = new Item(4, 2);
            Item item4 = new Item(4, 3);
            List<Item> items = new List<Item> { item1, item2, item3, item4 };
            DynamicProgramming dp = new DynamicProgramming();
            Console.WriteLine(dp.KnapSack(items, 6)); 

            //SpanningTree st = new Graphs.SpanningTree();
            //var output=st.KruskalSpanningTree();
            //for(int i=0;i<5;i++)
            //{
            //    for(int j=0;j<5;j++)
            //    {
            //        Console.WriteLine(output[i,j]);
            //    }
            //    Console.WriteLine( "-----");
            //}

            //Heap heap = new Heap();
            //HeapNode node1 = new HeapNode(1);
            //HeapNode node2 = new HeapNode(2);
            //HeapNode node3 = new HeapNode(7);
            //HeapNode node4 = new HeapNode(9);
            //heap.Insert(node1);
            //heap.Insert(node4);
            //heap.Insert(node3);
            //heap.Insert(node2);
            //heap.Delete(2);


            //BinarySearchTree bst = new BinarySearchTree();
            //Node newNode = new Node(8);
            //var a=bst.Insert(newNode);
            //var node = bst.Search(0);
            //if(node!=null)
            //    Console.WriteLine(node.Key);
            //else
            //    Console.WriteLine("Element not found");
            //var node = bst.Minimum();
            //Console.WriteLine(node.Key);
            //var sortedlist=heap.HeapSort();
            //foreach (var node in sortedlist)
            //    Console.WriteLine(node.Key);
            //UndirectedGraph g = new UndirectedGraph();

            //Search<string> search = new Search<string>();
            //List<string> output = search.DFS(g, g.node1);
            // List<string> output = search.BFS(g, g.node1);
            //List<string> output = search.PathBetweenTwoPoints(g, g.node1, g.node9);

            //foreach (string value in output)
            //{
            //    Console.WriteLine(value);
            //}
            //DirectedGraph g = new DirectedGraph();
            //search.DijkstraShortestPath(g, g.node1);
            //foreach (var node in g.nodeList)
            //    Console.WriteLine(node.data+"  "+node.greedyScore);

        }
    }
   
    class Node<T>
    {
        public T data;
        public int greedyScore { get; set; }
        public List<Edge<T>> edges = new List<Edge<T>>();
        public bool explored = false;
        public Node(T value, int gs=int.MaxValue)
        {
            data = value;
            greedyScore = gs;
        }
    }
    class Edge<T>
    {
        public string Name { get; set; }
        public Node<T> TailNode { get; set; }
        public Node<T> HeadNode { get; set; }
        public int Weight { get; set; }
        public Edge(Node<T> tailNode, Node<T> headNode, string name, int weight=1)
        {
            TailNode = tailNode;
            HeadNode = headNode;
            Name = name;
            Weight = weight;
        }
    }
    class UndirectedGraph
    {
        public Node<string> node1;
        public Node<string> node2;
        public Node<string> node3;
        public Node<string> node4;
        public Node<string> node5;
        public Node<string> node6;
        public Node<string> node7;
        public Node<string> node8;
        public Node<string> node9;
        public Node<string> node10;

        public Edge<string> edge12;
        public Edge<string> edge23;
        public Edge<string> edge34;
        public Edge<string> edge45;
        public Edge<string> edge56;
        public Edge<string> edge61;
        public Edge<string> edge110;
        public Edge<string> edge68;
        public Edge<string> edge87;
        public Edge<string> edge57;
        public Edge<string> edge25;
        public Edge<string> edge35;
        public Edge<string> edge49;

        public UndirectedGraph()
        {
            node1 = new Node<string>("Value1");
            node2 = new Node<string>("Value2");
            node3 = new Node<string>("Value3");
            node4 = new Node<string>("Value4");
            node5 = new Node<string>("Value5");
            node6 = new Node<string>("Value6");
            node7 = new Node<string>("Value7");
            node8 = new Node<string>("Value8");
            node9 = new Node<string>("Value9");
            node10 = new Node<string>("Value10");

            edge12 = new Edge<string>(node1, node2, "edge12");
            edge23 = new Edge<string>(node2, node3, "edge23");
            edge34 = new Edge<string>(node3, node4, "edge34");
            edge45 = new Edge<string>(node4, node5, "edge45");
            edge56 = new Edge<string>(node5, node6, "edge56");
            edge61 = new Edge<string>(node6, node1, "edge61");
            edge110 = new Edge<string>(node1, node10, "edge110");
            edge68 = new Edge<string>(node6, node8, "edge68");
            edge87 = new Edge<string>(node8, node7, "edge87");
            edge57 = new Edge<string>(node5, node7, "edge57");
            edge25 = new Edge<string>(node2, node5, "edge25");
            edge35 = new Edge<string>(node3, node5, "edge35");
            edge49 = new Edge<string>(node4, node9, "edge49");

            node1.edges.Add(edge12);
            node1.edges.Add(edge61);
            node1.edges.Add(edge110);
            node2.edges.Add(edge12);
            node2.edges.Add(edge23);
            node2.edges.Add(edge25);
            node3.edges.Add(edge23);
            node3.edges.Add(edge34);
            node3.edges.Add(edge35);
            node4.edges.Add(edge34);
            node4.edges.Add(edge45);
            node4.edges.Add(edge49);
            node5.edges.Add(edge45);
            node5.edges.Add(edge56);
            node5.edges.Add(edge25);
            node5.edges.Add(edge35);
            node5.edges.Add(edge57);
            node6.edges.Add(edge56);
            node6.edges.Add(edge61);
            node6.edges.Add(edge68);
            node7.edges.Add(edge57);
            node7.edges.Add(edge87);
            node8.edges.Add(edge68);
            node8.edges.Add(edge87);
            node9.edges.Add(edge49);
            node10.edges.Add(edge110);
        }
    }

    class DirectedGraph
    {
        public Node<string> node1;
        public Node<string> node2;
        public Node<string> node3;
        public Node<string> node4;
        public Node<string> node5;
        public Node<string> node6;
        public Node<string> node7;
        public Node<string> node8;
        public Node<string> node9;
        public Node<string> node10;

        public List<Node<string>> nodeList;

        public Edge<string> edge12;
        public Edge<string> edge23;
        public Edge<string> edge34;
        public Edge<string> edge45;
        public Edge<string> edge56;
        public Edge<string> edge61;
        public Edge<string> edge110;
        public Edge<string> edge68;
        public Edge<string> edge87;
        public Edge<string> edge57;
        public Edge<string> edge25;
        public Edge<string> edge35;
        public Edge<string> edge49;

        public DirectedGraph()
        {
            node1 = new Node<string>("Value1",int.MaxValue);
            node2 = new Node<string>("Value2",int.MaxValue);
            node3 = new Node<string>("Value3",int.MaxValue);
            node4 = new Node<string>("Value4", int.MaxValue);
            node5 = new Node<string>("Value5", int.MaxValue);
            node6 = new Node<string>("Value6", int.MaxValue);
            node7 = new Node<string>("Value7");
            node8 = new Node<string>("Value8");
            node9 = new Node<string>("Value9");
            node10 = new Node<string>("Value10");

            nodeList = new List<Node<string>>() { node1, node2, node3, node4, node5, node6, node7, node8, node9, node10 };

            edge12 = new Edge<string>(node1, node2, "edge12",5);
            edge23 = new Edge<string>(node2, node3, "edge23",3);
            edge34 = new Edge<string>(node3, node4, "edge34",1);
            edge45 = new Edge<string>(node4, node5, "edge45",5);
            edge56 = new Edge<string>(node5, node6, "edge56",2);
            edge61 = new Edge<string>(node6, node1, "edge61",7);
            edge110 = new Edge<string>(node1, node10, "edge110",5);
            edge68 = new Edge<string>(node6, node8, "edge68",4);
            edge87 = new Edge<string>(node8, node7, "edge87",3);
            edge57 = new Edge<string>(node5, node7, "edge57",1);
            edge25 = new Edge<string>(node2, node5, "edge25",2);
            edge35 = new Edge<string>(node3, node5, "edge35",6);
            edge49 = new Edge<string>(node4, node9, "edge49",2);
            
            node1.edges.Add(edge12);
            node1.edges.Add(edge110);
            node2.edges.Add(edge23);
            node2.edges.Add(edge25);
            node3.edges.Add(edge34);
            node3.edges.Add(edge35);
            node4.edges.Add(edge45);
            node4.edges.Add(edge49);
            node5.edges.Add(edge56);
            node5.edges.Add(edge57);
            node6.edges.Add(edge61);
            node6.edges.Add(edge68);
            node8.edges.Add(edge87);
        }
    }
    class Search<T>
    {
        List<T> outputDFS = new List<T>();
        List<string> path = new List<string>();
        bool destinationStatus = false;
        public List<T> BFS(UndirectedGraph g, Node<T> startingNode)
        {
            List<T> output = new List<T>();
            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(startingNode);
            startingNode.explored = true;
            while (queue.Count != 0)
            {
                var currentNode = queue.Dequeue();
                output.Add(currentNode.data);
                foreach (var edge in currentNode.edges)
                {
                    if (edge.TailNode.explored == false)
                    {
                        queue.Enqueue(edge.TailNode);
                        edge.TailNode.explored = true;
                    }
                    else if (edge.HeadNode.explored == false)
                    {
                        queue.Enqueue(edge.HeadNode);
                        edge.HeadNode.explored = true;
                    }
                }
            }

            return output;
        }

        public List<T> DFS(UndirectedGraph g, Node<T> startingNode)
        {
            outputDFS.Add(startingNode.data);
            startingNode.explored = true;
            foreach (Edge<T> edge in startingNode.edges)
            {
                if (!edge.TailNode.explored)
                {
                    DFS(g, edge.TailNode);
                }
                else if (!edge.HeadNode.explored)
                {
                    DFS(g, edge.HeadNode);
                }
            }

            return outputDFS;
        }
        public List<string> PathBetweenTwoPoints(UndirectedGraph g, Node<T> origin, Node<T> destination)
        {
            origin.explored = true;
            Random rnd = new Random();
            int edgeCount = origin.edges.Count;
            int rand = rnd.Next(0, edgeCount);
            int i = 0;

            i++;
            if (destinationStatus)
            {
                return path;
            }
            if (origin == destination)
            {
                destinationStatus = true;
                return path;
            }
            else if (!origin.edges[rand].HeadNode.explored)
            {
                path.Add(origin.edges[rand].Name);
                PathBetweenTwoPoints(g, origin.edges[rand].HeadNode, destination);
            }
            else if (!origin.edges[rand].TailNode.explored)
            {
                path.Add(origin.edges[rand].Name);
                PathBetweenTwoPoints(g, origin.edges[rand].TailNode, destination);
            }
            else
            {
                path.Add(origin.edges[rand].Name);
                PathBetweenTwoPoints(g, origin.edges[rand].TailNode, destination);
            }


            return path;
        }

        public void DijkstraShortestPath(DirectedGraph g, Node<string> start)
        {
            List<Node<string>> setX = new List<Node<string>>();
            List<Node<string>> setY = new List<Node<string>>();
            setX.Add(start);
            start.greedyScore = 0;
            foreach(Node<string> node in g.nodeList)
            {
                if (node != start)
                    setY.Add(node);
            }
            while (setY.Count>0)
            {
                foreach (Node<string> node in setX)
                {
                    foreach (Edge<string> edge in node.edges)
                    {
                        if (edge.HeadNode.greedyScore > node.greedyScore + edge.Weight)
                            edge.HeadNode.greedyScore = node.greedyScore + edge.Weight;
                    }
                }
                int min = int.MaxValue;
                Node<string> minNode=new Node<string>("tempnode");
                foreach (Node<string> node in setY)
                {
                    if (min > node.greedyScore)
                    {
                        min = node.greedyScore;
                        minNode = node;
                    }
                }
                setX.Add(minNode);
                setY.Remove(minNode);
            }
        }

       
    }
}

