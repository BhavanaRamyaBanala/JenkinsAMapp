// See https://aka.ms/new-console-template for more information
using JenkinsAutomateapp;
using System.Security;

Console.WriteLine("Joe's Pizza details!!");
Console.WriteLine("---------------------");
PizzaManagement pm = new PizzaManagement();
foreach (var p in pm.AllPizzas())
{
    Console.WriteLine("Id: "+p.Id);
    Console.WriteLine("Name: "+p.Name);
    Console.WriteLine("Price: "+p.Price);
    Console.WriteLine("---------------------");
}
