// See https://aka.ms/new-console-template for more information
Console.WriteLine("Skriv fem tall åt gång och jag kommer skriva dom i omvänd ordning");
int[] v = new int[5];
v[0] = int.Parse(Console.ReadLine());
Console.WriteLine("Skriv de andra tal");
v[1] = int.Parse(Console.ReadLine());
Console.WriteLine("Skriv den tredje");
v[2] = int.Parse(Console.ReadLine());
Console.WriteLine("Skriv den fjärde");
v[3] = int.Parse(Console.ReadLine());
Console.WriteLine("Skriv den femte");
v[4] = int.Parse(Console.ReadLine());
Console.WriteLine(v[4]);
Console.WriteLine(v[3]);
Console.WriteLine(v[2]);
Console.WriteLine(v[1]);
Console.WriteLine(v[0]);