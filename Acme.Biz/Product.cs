using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in inventory
    /// </summary>
    public class Product
    {
        // Private Fields
        private string productName;
        private string description;
        private int productId;

        // Properties
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }

        // Simple message to display product info
        public string SayHello()
        {
            return $"Hello {ProductName} ({ProductId}): {Description}";
        }

        // Default Constructor - prints message
        public Product()
        {
            Console.WriteLine("Product instance created");
        }

        // Param Constructor to initialize properties and write a message
        public Product(int productId, string productName, string description) : this()
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Description = description;

            Console.WriteLine($"Product instance has a name: {ProductName}");
        }

    }
} 
  