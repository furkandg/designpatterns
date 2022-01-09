// See https://aka.ms/new-console-template for more information
using IteratorDesignPattern.IteratorDesignPattern;

ConcreteAggregate a = new ConcreteAggregate();
a[0] = "Item A";
a[1] = "Item B";
a[2] = "Item C";
a[3] = "Item D";

ConcreteIterator i = new ConcreteIterator(a);

Console.WriteLine("Iterating over collection");
object item = i.First();

while (item !=null)
{ 
    Console.WriteLine(item);
    item = i.Next();
}
Console.ReadKey();
