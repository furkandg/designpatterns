// See https://aka.ms/new-console-template for more information
using StateDesignPattern.StateDesignPattern;

Console.WriteLine("Hello, World!");

Server server = new();
server.AddProgram(20);
server.AddProgram(10);
server.AddProgram(30);
Console.ReadLine();