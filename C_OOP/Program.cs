// See https://aka.ms/new-console-template for more information
using C_OOP;
using System.Runtime.CompilerServices;

//Console.WriteLine("Hello, World!");
//Homework0507
//var calc = new Homework0507();
//double square1 = calc.CalcTriangleSquare(10, 20);
//double square2 = calc.CalcTriangleSquare(10, 20, 50);
//double square3 = calc.CalcTriangleSquare(10, 20, 50, false);

//Console.WriteLine($"square1 = {square1}, square2 = {square2}, square3 = {square3}");

//Homework0509
var roman = new Homework0509();
Console.WriteLine("Write roman numeric:");
int result = roman.RomanNumerals(Console.ReadLine());
Console.WriteLine($"result = {result}");