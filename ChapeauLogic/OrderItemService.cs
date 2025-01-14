using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class OrderItemService
    {
        private OrderItemDAO orderItemDAO;

        public OrderItemService()
        {
            orderItemDAO = new OrderItemDAO();
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            orderItemDAO.AddOrderItem(orderItem);
        }
        public void UpdateOrderState(int orderState, int orderID)
        {
            orderItemDAO.UpdateOrderState(orderState, orderID);
        }
    }
}
