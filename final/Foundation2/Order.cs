using System;
using System.Collections.Generic;

namespace CustomerManagement
{

public class Order
    {
        public Customer _customer;
        public List<Product> _products = new List<Product>();

        public Order(Customer customer)
        {
            _customer = customer;
        }

        public double DisplayTotalCost()
        {
            double totalCost = 0;
            foreach (var product in _products)
            {
                totalCost += product.GetTotalCost();
            }

            totalCost += _customer.CustomerLivesInUSA() ? 5 : 35;

            return totalCost;
        }

        public string DisplayPackingLabel()
        {
            string packingLabel = "Packing Label:\n";
            packingLabel += "----------------\n";
            foreach (var product in _products)
            {
                packingLabel += $"{product.GetProductName()} (ID: {product.GetProductId()})\n";
            }
            return packingLabel;
        }

        public string DisplayShippingLabel()
        {
            string shippingLabel = "Shipping Label:\n";
            shippingLabel += "----------------\n";
            shippingLabel += $"Name: {_customer.GetName()}\n";
            shippingLabel += $"Address:\n{_customer._address.CustomerFullAddress()}\n";
            return shippingLabel;
        }

         public void AddProductToOrder(List<Product> products, Order order)
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products available. Please add a product first.");
                return;
            }

            Console.WriteLine("Available products:");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].GetProductName()} - ${products[i].GetProductPrice():0.00} (Quantity: {products[i].GetProductQuantity()})");
            }

            Console.Write("Enter the product number to add to the order: ");
            if (int.TryParse(Console.ReadLine(), out int productIndex) && productIndex > 0 && productIndex <= products.Count)
            {
                order._products.Add(products[productIndex - 1]);
                Console.WriteLine("Product added to the order successfully.");
            }
            else
            {
                Console.WriteLine("Invalid product number, please try again.");
            }
        }
    }
}