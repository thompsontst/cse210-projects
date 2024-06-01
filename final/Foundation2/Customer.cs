using System;
using System.Collections.Generic;

namespace CustomerManagement
{
    public class Customer
    {
        private string _name;
        public Address _address;

    public string GetName ()
        {
            return _name;
        }
        
        public void SetName (string name)
        {
            _name = name;
        }

        public bool CustomerLivesInUSA()
        {
            return _address.IsCustomerInUSA();
        }

          public void AddCustomerInformation(Customer customer)
        {
            Console.Write("Enter customer name: ");
            customer._name = Console.ReadLine();

            Console.Write("Enter street address: ");
            string street = Console.ReadLine();

            Console.Write("Enter city: ");
            string city = Console.ReadLine();

            Console.Write("Enter state/province: ");
            string state = Console.ReadLine();

            Console.Write("Enter country: ");
            string country = Console.ReadLine();

            customer._address = new Address (street, city, state, country );
            Console.WriteLine("Customer details added successfully.");
        }
    }
}