using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class ProductRepository : GenericRepository<Product>, iProducts
    {
        public ProductRepository(SuperStoreContext context) : base(context)
        {
        }

        public Product GetMostRecentProduct()
        {
            return _context.Products.OrderByDescending(product => product.ProductId).FirstOrDefault();
        }
    }
}
