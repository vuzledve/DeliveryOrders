using DeliveryOrders_3.Domain.Entities;
using DeliveryOrders_3.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DeliveryOrders_3.Domain.Repositories.EntityFramework
{
    public class EFDeliveryOrdersRepository : IDeliveryOrdersRepository
    {
        private readonly AppDbContext context;
        public EFDeliveryOrdersRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<DeliveryOrder> GetDeliveryOrders()
        {
            return context.DeliveryOrders;
        }

        public void SaveDeliveryOrder(DeliveryOrder entity)
        {
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        //public void SaveDeliveryOrder(DeliveryOrder entity)
        //{
        //    if (entity.Id == default)
        //        context.Entry(entity).State = EntityState.Added;
        //    else
        //        context.Entry(entity).State = EntityState.Modified;
        //    context.SaveChanges();
        //}
        //public DeliveryOrder GetDeliveryOrderById(Guid id)
        //{
        //    return context.DeliveryOrders.FirstOrDefault(x => x.Id == id);
        //}
        //public void DeleteDeliveryOrder(Guid id)
        //{
        //    context.DeliveryOrders.Remove(new DeliveryOrder() { Id = id });
        //    context.SaveChanges();
        //}
    }
}
