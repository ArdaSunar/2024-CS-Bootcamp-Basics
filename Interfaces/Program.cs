// See https://aka.ms/new-console-template for more information
using Interfaces.Entities.Abstract;
using Interfaces.Entities.Concrete;

//InterfacesIntro();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(new OracleCustomerDal());
Console.ReadLine();

static void InterfacesIntro()
{
    PersonManager manager = new PersonManager();
    manager.Add(new Customer { Id = 1, FirstName = "Arda", LastName = "Sunar", Adress = "Samsun" });

    Student student = new Student
    {
        Id = 2,
        FirstName = "Abuzer",
        LastName = "Sunar",
        Department = "Computer Science"
    };

    manager.Add(student);
}