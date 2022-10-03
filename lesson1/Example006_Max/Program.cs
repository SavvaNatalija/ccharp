int a = new Random().Next(1,9);
int b = new Random().Next(1,9);
int c = new Random().Next(1,9);
int d = new Random().Next(1,9);
int e = new Random().Next(1,9);
Console.WriteLine(a + " "+ b + " " + c + " " + d + " " + e );

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.WriteLine("Максимальное число " + max);