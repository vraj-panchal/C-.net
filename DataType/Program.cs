// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Basic Data Type in C#


//int 
using System.Reflection.PortableExecutable;

int i = 5;
Console.WriteLine(" Integer : " + i);

// Character
char a = 'v';
Console.WriteLine(" Character : " + a);

// long  
long l = 110106;

Console.WriteLine(" Long : " +  l);

//double

double d = 3.1423;
Console.WriteLine(" Double : " +  d);

//float
float f = 7.20F;

Console.WriteLine(" Float : " + f);

//string 
string s = "vraj";

Console.WriteLine(" String : " + s);

//Array 

//string Array 

string[] cars = { "Volvo", "BMW", "i20", "Nano" };

    //Only Spacific Car Print 

Console.WriteLine(" String Array : " + cars[0]);

//chang Car Name 

cars[0] = "i10";

Console.WriteLine(" Change Volvo To i10 : " + cars[0]);

// Print all the cars using a for loop
Console.WriteLine("List of Cars:");
for (int j = 0; j < cars.Length; j++)
{
    Console.WriteLine($" Car {j + 1} : {cars[j]}");
}