using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            Customer customer = new Customer() { Id = 1, FirstName = "Alper Enes", LastName = "Yavuz", DateOfBirth = new DateTime(2002, 2, 18),NationalityId = "12345678910"};
            baseCustomerManager.Save(customer);
            
        }
    }
}
