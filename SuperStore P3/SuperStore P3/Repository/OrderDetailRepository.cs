using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>, iOrderDetails
    {
        public OrderDetailRepository(SuperStoreContext context) : base(context)
        {
        }

        public OrderDetail GetMostRecentOrderDetail()
        {
            return _context.OrderDetails.OrderByDescending(service => service.CreatedDate).FirstOrDefault();
        }
    }
}
