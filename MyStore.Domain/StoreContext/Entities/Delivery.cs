using MyStore.Domain.StoreContext.Enums;
using System;

namespace MyStore.Domain.StoreContext.Entities
{
    public class Delivery
    {
        public Delivery(DateTime estimatedDeliveryDate)
        {
            CreateDate = DateTime.Now;
            EstimatedDeliveryDate = estimatedDeliveryDate;
            Status = EDeliveryStatus.Waiting;
        }

        public DateTime CreateDate { get; private set; }
        public DateTime EstimatedDeliveryDate { get; private set; }
        public EDeliveryStatus Status { get; private set; }

        public void Ship()
        {
            //se a data estimada de entrega for no passado n�o entregar
            Status = EDeliveryStatus.Shipped;
        }

        public void Cancel()
        {
            //se o status j� estiver entregue, n�o pode cancelar
            Status = EDeliveryStatus.Canceled;
        }
    }
}