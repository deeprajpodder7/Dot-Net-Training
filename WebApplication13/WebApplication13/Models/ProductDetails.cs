namespace WebApplication13.Models
    {

    public interface IProductDetails
        {
        public List<Product> GetProducts();
        }

    public class ProductDetails:IProductDetails
        {
        public List<Product> GetProducts()
            {
            var products = new List<Product>()
{
new Product()
{
ProductId = 1,
ProductName="Xbox",
Quantity=3,
Price=49999

},

new Product()
{
ProductId = 2,
ProductName="Laptop",
Quantity=5,
Price=79999

},

new Product()
{
ProductId = 3,
ProductName="PS5",
Quantity=3,
Price=54999

}

};
            return products;
            }
        }
    }
