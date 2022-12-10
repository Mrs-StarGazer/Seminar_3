Console.WriteLine ("введите Х координат первой точки");
int x1=int.Parse(Console.ReadLine ()!);
Console.WriteLine ("введите y координат первой точки");
int y1=int.Parse(Console.ReadLine ()!);
Console.WriteLine ("введите z координат первой точки");
int z1=int.Parse(Console.ReadLine ()!);
Console.WriteLine ("введите y координат второй точки");
int x2=int.Parse(Console.ReadLine ()!);
Console.WriteLine ("введите Х координат второй точки");
int y2=int.Parse(Console.ReadLine ()!);
Console.WriteLine ("введите z координат второй точки");
int z2=int.Parse(Console.ReadLine ()!);

double sqrt=Math.Sqrt (Math.Pow (x1-x2, 2)+ Math.Pow (y1-y2, 2) + Math.Pow (z1-z2, 2));

Console.WriteLine (sqrt);