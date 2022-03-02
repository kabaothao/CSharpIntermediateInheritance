// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");




using System;

namespace CSharpIntermediateInheritance // Note: actual namespace depends on the project name.
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
        }
    }
}




/*
 What is Inheritance?
A kind of relationship between two classes that allows on to inherit code from the other.
Is - A
Example: A Car is a Vehicle.
 

Again I'll convert inheritance in more details in the section called inheritance for this section.

All I wanted to take away is that inheritance is a kind of relationship or association between classes

and it has two benefits.

One is code reuse.


 */