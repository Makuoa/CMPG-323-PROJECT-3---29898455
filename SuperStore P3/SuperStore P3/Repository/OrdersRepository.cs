using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrdersRepository : GenericRepository<Order>, iOrders
    {
        public OrdersRepository(SuperStoreContext context) : base(context)
        {
        }

        public Order GetMostRecentOrder()
        {
            return _context.Orders.OrderByDescending(service => service.CreatedDate).FirstOrDefault();
        }
    }
}
