int A = 1;
int B = 8;
int C = 6;
int D = 3;
int E = 5;

int max = A;

if (A > max) max = A;
if (B > max) max = B;
if (C > max) max = C;
if (D > max) max = D;
if (E > max) max = E;

Console.Write("max =");
Console.WriteLine(max);