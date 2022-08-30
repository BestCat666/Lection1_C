int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int maх = a;

if (a > maх) maх = a;
if (b > maх) maх = b;
if (c > maх) maх = c;
if (d > maх) maх = d;
if (e > maх) maх = e;

Console.Write("maх = ");
Console.WriteLine(maх);