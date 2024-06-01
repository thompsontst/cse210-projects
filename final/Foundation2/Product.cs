  using System;
using System.Collections.Generic;

namespace CustomerManagement
{
  
   public class Product
    {
        private string _productName;
        private string _productId;
        private double _productprice;
        private int _quantity;

        public string GetProductName()
        {
            return _productName;
        }
        
        
        public void SetProductName(string productName)
        {
            _productName = productName;
        }

        
        public string GetProductId()
        {
            return _productId;
        }
        
        
        public void SetProductId(string productId)
        {
            _productId = productId;
        }
        
        public double GetProductPrice()
        {
            return _productprice;
        }
        
        public void SetProductprice(double productprice)
        {
            _productprice = productprice;
        }

        public int GetProductQuantity()
        {
            return _quantity;
        }
        
        public void SetProductQuantity( int ProductQuantity)
        {
            _quantity = ProductQuantity;
        }
        public double GetTotalCost()
        {
            
            
                return _productprice * _quantity;
            
        }
        public void AddNewProduct(List<Product> products)
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            
            Console.Write("Enter product ID: ");
            string id = Console.ReadLine();
            
            Console.Write("Enter product price: ");
            if (double.TryParse(Console.ReadLine(), out double price))
            {
                Console.Write("Enter product quantity: ");
                if (int.TryParse(Console.ReadLine(), out int quantity))
                {
                    products.Add(new Product { _productName = name, _productId = id, _productprice = price, _quantity = quantity });
                    Console.WriteLine("Product added successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid quantity. Please enter a valid number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid price. Please enter a valid number.");
            }
        }

    }
}