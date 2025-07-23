namespace bellossomIT.Models.Repository;

public class ProductRepository : IProductRepository
{
    private static List<Product> _products = new List<Product>
    {
        //instanciar alguns produtos aqui e no controller pegar td!
        private static readonly List<Product> _products = new List<Product>
        {
            //instanciar bonitinho
        };

        public List<Product> GetAll()
        {
            return _products;
        }
    }
}