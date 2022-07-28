using DeliveryOrders_3.Domain.Entities;

namespace DeliveryOrders_3.Domain.Repositories.Abstract
{
    public interface IDeliveryOrdersRepository
    {
        IQueryable<DeliveryOrder> GetDeliveryOrders();
     
        void SaveDeliveryOrder(DeliveryOrder entity);

        //  DeliveryOrder GetServiceItemById(Guid id);
        //  void DeleteServiceItem(Guid id);
    }
}
