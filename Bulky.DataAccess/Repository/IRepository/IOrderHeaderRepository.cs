using Bulky.Models;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        void Update(OrderHeader obj);
        // based on Id only update orderstaus and paymanet status
        void UpdateStatus(int id, string orderStatus, string? paymentStatus=null);
        void UpdateStripePaymentID(int id, string sessionId, string? paymentIndentId);
    }
}