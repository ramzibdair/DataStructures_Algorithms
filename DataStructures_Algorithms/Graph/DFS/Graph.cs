using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS
{
    internal class Graph
    {
        private readonly int Vertices;
        private List<int>[] Edges;

        public Graph(int verties)
        {
            Vertices = verties;
            Edges = new List<int>[verties];
        }
        public void AddEdge(int source ,int[] destination)
        {
            Edges[source] = new List<int>();
            Edges[source].AddRange(destination);
        }
        public void DFSUtility(int vertix,bool[] visited )
        {
            if (!visited[vertix])
            {
                Console.Write($"{vertix} ");
                visited[vertix] = true;
                foreach (var edge in Edges[vertix])
                {
                    DFSUtility(edge, visited);
                }
            }
            
        }

        public void DFS(int root)
        {
            bool[] visited = new bool[Vertices];
            Console.Write($"{root} ");
            visited[root] = true;
            foreach(var edge in Edges[root])
            {
                DFSUtility(edge, visited);
            }
        }
    }
}
