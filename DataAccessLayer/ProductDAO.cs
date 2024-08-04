using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductDAO
    {
       
        List<Product> list = new List<Product>();

        public List<Product> GetProducts()
        {
            
            list.AddRange(new List<Product>());
                new Product { ProductId = 1, ProductName = "Chai", CategoryId = 3, UnitsInStock = 12, UnitPrice = 18 },
                new Product { ProductId = 2, ProductName = "Chang", CategoryId = 1, UnitsInStock = 23, UnitPrice = 19 },
                new Product { ProductId = 3, ProductName = "Aniseed Syrup", CategoryId = 2, UnitsInStock = 23, UnitPrice = 10 }
            );
            return list;
        }

        public void SaveProduct(Product p)
        {
            list.Add(p);
        }
        public void UpdateProduct(Product p)
        {
            foreach(var current in list.ToList())
            {
                if (current.ProductId == p.ProductId)
                {
                    current.ProductName = p.ProductName;
                    current.CategoryId = p.CategoryId;
                    current.ProductId = p.ProductId;
                    current.UnitPrice = p.UnitPrice;    
                    current.UnitsInStock = p.UnitsInStock;
                }
            }
        }
        public void DeleteProduct(Product p)
        {
            foreach (var current in list.ToList())
            {
                if (current.ProductId == p.ProductId)
                {
                    list.Remove(p);
                }
            }
        }
        public Product GetProductId (int id)
        {
            foreach (var current in list.ToList())
            {
                if (current.ProductId == id)
                {
                   return current;
                }
                return null;
            }
        }
    }
}
