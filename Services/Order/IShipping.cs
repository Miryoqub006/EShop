//----------------------------------------
// Miryoqub tg:@Avenger_uzb A.K.A (c) All rights reserved
//----------------------------------------

namespace EShop.Services.Order
{
    public interface IShipping
    {
        double GetCost(OrderService order);
        DateTimeOffset GetDate();
    }
}