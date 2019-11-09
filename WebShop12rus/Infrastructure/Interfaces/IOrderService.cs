using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop12rus.Domain.Entities;
using WebShop12rus.ViewModels;

namespace WebShop12rus.Infrastructure.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<Order> GetUserOrders(string UserName);

        Order GetOrderById(int id);
        Order CreateOrder(OrderViewModel orderViewModel, CartViewModel cartViewModel, string UserName);
    }
}
