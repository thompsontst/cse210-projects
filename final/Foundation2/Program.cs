
using System;
using System.Collections.Generic;

namespace CustomerManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Customer customer01 = new Customer();
            Order order = new Order(customer01);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nOrder Management System Menu:");
                Console.WriteLine("1. Add a new product");
                Console.WriteLine("2. Add customer details");
                Console.WriteLine("3. Add product to order");
                Console.WriteLine("4. Calculate total cost of the order");
                Console.WriteLine("5. Print packing label");
                Console.WriteLine("6. Print shipping label");
                Console.WriteLine("7. Exit");
                Console.Write("Select an option (1-7): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Product product01 = new Product();
                        product01.AddNewProduct(products);
                        break;
                    case "2":
                        customer01.AddCustomerInformation(customer01);
                        break;
                    case "3":
                        order.AddProductToOrder(products, order);
                        break;
                    case "4":
                        Console.WriteLine($"Total cost of the order: ${order.DisplayTotalCost():0.00}");
                        break;
                    case "5":
                        Console.WriteLine(order.DisplayPackingLabel());
                        break;
                    case "6":
                        Console.WriteLine(order.DisplayShippingLabel());
                        break;
                    case "7":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

       

      

       
    }

   


  


    
}
