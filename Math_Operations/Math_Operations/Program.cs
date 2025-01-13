// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


int a = 20;
int b = 30;

// Math Operation 
int sum = a  + b;
int difference = a - b;
int Multiplication = a * b;
double Division = (double)a / b;

Console.WriteLine($" Sum : {sum}");
Console.WriteLine($" Difference : {difference}");
Console.WriteLine($" Multiplication : {Multiplication}");
Console.WriteLine($" Division : {Division}");


//Math.sin() - Absolute Value

int x = Math.Sign(10);
int y = Math.Sign(- 10);

Console.WriteLine($" sing of x  :{x}");  // Result: 1
Console.WriteLine($" sing of y  :{y}");  // Result: -1


//Math.Pow() - Power

double result = Math.Pow(2,6);

Console.WriteLine($" Result (2^6) : {result}"); // 2^6 = 64


//Math.Sqrt() - Square Root


double s = Math.Sqrt(16);

Console.WriteLine($" Square Root of 16 : {s}"); // Result: 4


//Math.Max() and Math.Min()


int maxResult = Math.Max(10, 20);  // Result: 20
int minResult = Math.Min(10, 20);  // Result: 10
Console.WriteLine($" Max: {maxResult}, Min: {minResult}");



