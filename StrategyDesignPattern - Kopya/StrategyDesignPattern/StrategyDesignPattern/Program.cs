// See https://aka.ms/new-console-template for more information
using StrategyDesignPattern.StrategyPattern;


IStrategy selectedStrategy = ConverterFactory.CreateConverterClass("mp3");
selectedStrategy.Convert();
Console.ReadKey();