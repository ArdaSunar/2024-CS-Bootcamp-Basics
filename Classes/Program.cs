// See https://aka.ms/new-console-template for more information
using Classes;

CustomerManager customerManager = new CustomerManager();

customerManager.Add();
customerManager.Update();

Customer customer1 = new Customer
{
    Id = 1,
    City = "Samsun",
    FirstName = "Arda",
    LastName = "Sunar"
};

Console.WriteLine(customer1.FirstName);
Console.WriteLine(customer1.LastName);
Console.WriteLine(customer1.Id);
Console.WriteLine(customer1.City);

