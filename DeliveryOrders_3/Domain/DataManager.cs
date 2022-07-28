using DeliveryOrders_3.Domain.Repositories.Abstract;
namespace DeliveryOrders_3.Domain
{

    //точка входа для DbContext
    public class DataManager
    {
        public IDeliveryOrdersRepository DeliveryOrders { get; set; }
    

        public DataManager(IDeliveryOrdersRepository deliveryOrdersRepository)
        {
            DeliveryOrders = deliveryOrdersRepository;
        }
    }
}
