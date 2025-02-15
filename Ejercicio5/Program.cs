using System;

Console.Write("Ingrese el primer número: ");
string input1 = Console.ReadLine();

Console.Write("Ingrese el segundo número: ");
string input2 = Console.ReadLine();

int num1 = int.Parse(input1);
int num2 = int.Parse(input2);

int suma = num1 + num2;

Console.WriteLine("La suma de los dos números ess: " + suma);
