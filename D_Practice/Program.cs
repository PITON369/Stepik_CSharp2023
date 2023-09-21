// See https://aka.ms/new-console-template for more information
using C_OOP;
using System.Runtime.CompilerServices;

//Homework0801
var first = new Complex(1, 1);
var second = new Complex(1, 1);
var answer = new Complex(0, 0);

answer = first.Plus(second);
Console.WriteLine($"Complex first ({first.Real}, {first.Imaginary}) + Complex second ({second.Real}, {second.Imaginary}) = {answer.Real} {answer.Imaginary}");

answer = Complex.Plus(first, second);
Console.WriteLine($"Complex first ({first.Real}, {first.Imaginary}) + Complex second ({second.Real}, {second.Imaginary}) =  {answer.Real} {answer.Imaginary}");

answer = first.Minus(second);
Console.WriteLine($"Complex first ({first.Real}, {first.Imaginary}) - Complex second ({second.Real}, {second.Imaginary}) =  {answer.Real} {answer.Imaginary}");

answer = Complex.Minus(first, second);
Console.WriteLine($"Complex first ({first.Real}, {first.Imaginary}) - Complex second ({second.Real}, {second.Imaginary}) =  {answer.Real} {answer.Imaginary}");