using ConsoleAppSample;
using System;
using System.Threading.Tasks;

SampleCode sample = new SampleCode();
await sample.Print("Hello");
await sample.Print("World");
await sample.Print("Ali");





///// لطفا نمونه بنویسید که خروجی بالا به صورت Async

Console.WriteLine("Start Async");

PrintClass print = new PrintClass();
await print.Print("Hello");
await print.Print("World");
await print.Print("Ali");

//// لطفا نمونه بنویسید که خروجی بالا به صورت موازی اجرا شود

Console.WriteLine("Start Parallel");

Task printHello = new Task(delegate
{
    PrintClass.ParallelPrint("Hello");
});
Task printWorld = new Task(delegate
{
    PrintClass.ParallelPrint("World");
});
Task printAli = new Task(delegate
{
    PrintClass.ParallelPrint("Ali");
});

printHello.Start();
printWorld.Start();
printAli.Start();

Console.ReadLine();
