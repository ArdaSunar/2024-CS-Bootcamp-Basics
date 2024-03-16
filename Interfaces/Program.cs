// See https://aka.ms/new-console-template for more information
using Interfaces.Entities.Abstract;
using Interfaces.Entities.Concrete;

//InterfacesIntro();

//Demo();

ICustomerDal[] customerDals = new ICustomerDal[2]
{
    new SqlServerCustomerDal(),
    new OracleCustomerDal()
};

foreach (var customerDal in customerDals)
{
    customerDal.Add();
}

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

static void Demo()
{
    CustomerManager customerManager = new CustomerManager();
    customerManager.Add(new OracleCustomerDal());
}