// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Laxsikan Manoranjan!");
//Console.WriteLine("Version:{0}",Environment.Version.ToString());
//string text = System.IO.File.ReadAllText("text.text");
//Console.WriteLine(text);
//Completed 1/17/2023
/*
 * Task 2 was completed by Laxsikan Manoranjan 
 */
int myNum = 15;
Console.WriteLine("myNum was: " + myNum);
myNum = 20; // myNum is now 20
Console.WriteLine("myNum is now: " + myNum);

string[] sections = { "CPS*3330*01", "CPS*3330*02", "TECH*4982*01"};

//print the length
Console.WriteLine("The number of section is " + sections.Length);

//reverse it
Array.Reverse(sections);
Console.Write("\nIn reverse: ");

//print them all using foreach loop
foreach(var e in sections)
    Console.WriteLine(e.ToString() + " ");

Console.WriteLine("\nUsing foreach method: ");
sections.ToList().ForEach(e => Console.Write(e.ToString() + ""));

Console.WriteLine("\n\nUsing Array class and its method:");
Array.ForEach(sections, Console.WriteLine);