// See https://aka.ms/new-console-template for more information
using Cache_LRU;

Console.WriteLine("Hello, World!");
var cache = new Cache(5);
Console.WriteLine( "add Key a with value = " + cache.Set("a", "ramzi"));
Console.WriteLine("add Key b with value = " + cache.Set("b", "mousa"));
Console.WriteLine("add Key c with value = " + cache.Set("c", "bdair"));
Console.WriteLine("duplicate Key a with value = " + cache.Set("a", "ramzi"));
Console.WriteLine("add Key d with value = " + cache.Set("d", "20"));
Console.WriteLine("add Key e with value = " + cache.Set("e", "03"));
Console.WriteLine("duplicate Key a with change value = " + cache.Set("a", "RAMZI"));

Console.WriteLine("read Key a with value = " + cache.Get("a"));
Console.WriteLine("read Key b with value = " + cache.Get("b"));
Console.WriteLine("read Key c with value = " + cache.Get("c"));
Console.WriteLine("read Key d with value = " + cache.Get("d"));
Console.WriteLine("read Key e with value = " + cache.Get("e"));
Console.WriteLine("add Key f with value = " + cache.Set("f", "1989"));


