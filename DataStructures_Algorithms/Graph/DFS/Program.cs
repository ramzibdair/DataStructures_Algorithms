// See https://aka.ms/new-console-template for more information
using DFS;

Console.WriteLine(" \x1b[1mInput\x1b[0m : n = 4, e = 6 ");
Console.WriteLine("\x1b[1mEdges\x1b[0m : 0 -> 1, 0 -> 2, 1 -> 2, 2 -> 0, 2 -> 3, 3 -> 3 ");
Console.WriteLine("\x1b[1mOutput\x1b[0m: DFS from vertex 1 : 1 2 0 3 \n\n");
Graph g = new Graph(4);

g.AddEdge(0,new int[2] { 1,2 });
g.AddEdge(1, new int[1] { 2 });
g.AddEdge(2, new int[2] { 0,3 });
g.AddEdge(3, new int[1] {  3 });

Console.WriteLine( "Following is the result of our algorithm:");

g.DFS(1);
Console.ReadKey();