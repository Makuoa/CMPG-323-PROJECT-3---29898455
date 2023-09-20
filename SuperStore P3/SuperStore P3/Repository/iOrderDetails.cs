using Data;
using Models;
using static EcoPower_Logistics.Repository.IGenericRepository;

namespace EcoPower_Logistics.Repository
{
    public interface iOrderDetails : IGenericRepository<OrderDetail>
    {
        OrderDetail GetMostRecentOrderDetail();
    }
}
