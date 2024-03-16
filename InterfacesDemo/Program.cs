// See https://aka.ms/new-console-template for more information
using InterfacesDemo.Entities;

Console.WriteLine("Hello, World!");


IWorker[] workers = new IWorker[3]
{
    new Manager(),
    new Worker(),
    new Robot(),
};

foreach (var worker in workers)
{
    worker.Work();
}

IEat[] workers1 = new IEat[2]
{
    new Worker(),
    new Manager()
};

