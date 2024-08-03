using BusinessObjects;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        List<Product> list = new List<Product>();

        public List<Product> GetProducts()
        {
            list.Add(
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
    }
}
