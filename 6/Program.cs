// a=5. b=6, c=3, d=8, e=2
int a = 5;
int b = 6;
int c = 3;
int d = 8;
int e = 2;

int max = a;


if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("Максимальное число= ");
Console.WriteLine(max);
